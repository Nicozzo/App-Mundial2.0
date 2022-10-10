using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using System.Linq;
using Excepciones;
using Microsoft.EntityFrameworkCore;

namespace LogicaAccesoDatos.BaseDatos
{
    public class RepositorioPartido : IRepositorioPartido
    {

        public LibreriaContext Contexto { get; set; }

        public static List<Partido> Partidos { get; set; } = new List<Partido>();


        public RepositorioPartido(LibreriaContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(Partido obj)
        {
            DateTime incial = new DateTime(2022, 11, 20);
            DateTime final = new DateTime(2022, 12, 3);
            
           
            try
            {
                Partidos = Contexto.Partido
                   .ToList();

                List<Seleccion> selecciones = new List<Seleccion>();
                selecciones = Contexto.Seleccion
                                .ToList();

                Seleccion Localaux = null;

                Seleccion Visitanteaux = null;
                foreach (var item in selecciones)
                {
                    if (item.ID == obj.idSelccionLocal)
                    {
                        Localaux = item;
                    }
                    if (item.ID == obj.idSelccionVisitante)
                    {
                        Visitanteaux = item;
                    }
                }



                if ((obj.date.Hour != 07) && (obj.date.Hour != 10) && (obj.date.Hour != 13) && (obj.date.Hour != 16))
                {
                    throw new PaisException("La hora ingresada no es una de las 4 horas posibles");
                }

                if (obj.date < incial || obj.date > final)
                {
                    throw new PaisException("La fecha no queda entre las dos fechas tope (20/ 11 /2022 y 2 / 12 / 2022)");
                }
                if (obj.idSelccionLocal == obj.idSelccionVisitante)
                {
                    throw new PaisException("La seleccion no puede jugar contra ella misma");
                }
                if (Localaux.Grupo != Visitanteaux.Grupo)
                {
                    throw new PaisException("Las selecciones no estan en el mismo grupo");
                }
                foreach (var item in Partidos)
                {


                    foreach (var item2 in Partidos)
                    {
                        if (item.ID == item2.ID)
                        {
                            if (item.idSelccionLocal == obj.idSelccionLocal && item.idSelccionVisitante == obj.idSelccionVisitante && item.idSelccionLocal == obj.idSelccionVisitante && item.idSelccionVisitante == obj.idSelccionLocal)
                            {
                                throw new PaisException("Las selecciones ya jugaron entre si");
                            }
                        }
                    }

                    
                    if (obj.date.Day == item.date.Day)
                    {
                        int cont = 0;
                        foreach (var item2 in Partidos)
                        {
                            if (item2.date.Day == item.date.Day)
                            {
                                cont++;
                                if (item2.date.Hour == obj.date.Hour)
                                {
                                    throw new PaisException("El dia ya tiene un Partido a esa hora");
                                }
                            }
                            if (cont >= 4)
                            {
                                throw new PaisException("El Dia ya tiene los 4 partidos");
                            }

                        }
                        if (obj.date.Hour == item.date.Hour)
                        {
                            throw new PaisException("El dia ya tiene un Partido a esa hora");
                        }
                    }
                }

                Contexto.Partido.Add(obj);
                Contexto.SaveChanges();
            }
            catch (PaisException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo realizar el alta de seleccion", e);
            }
        }

        public IEnumerable<Partido> FindAll()
        {
            return Contexto.Partido
                   .ToList();
        }

        public Partido FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Partido obj)
        {
            throw new NotImplementedException();
        }
    }
}
