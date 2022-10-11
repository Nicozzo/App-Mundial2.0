using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using Excepciones;
using System.Linq;
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


                if ((obj.date.Hour != 07) && (obj.date.Hour != 10) && (obj.date.Hour != 13) && (obj.date.Hour != 16))
                {
                    throw new PaisException("La hora ingresada no es una de las 4 horas posibles");
                }

                if (obj.date < incial || obj.date > final)
                {
                    throw new PaisException("La fecha no queda entre las dos fechas tope (20/ 11 /2022 y 2 / 12 / 2022)");
                }
               
                foreach (var item in Partidos)
                {

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

                int aux = 0;
                int contador = 0;
                Partido nuevo = new Partido();
                nuevo.date = obj.date;
               
                List<SeleccionPartido> pubAutors = new List<SeleccionPartido>();
                foreach (var item in obj.PartidoSelecciones)
                {
                    if (aux == item.idseleccion)
                    {
                        throw new PaisException("No puede jugar la misma seleccion ");
                    }
                    aux = item.idseleccion;
                    contador++;
                    SeleccionPartido sp = new SeleccionPartido();
                    sp.idseleccion = item.idseleccion;
                    pubAutors.Add(sp);
                    
                }
                

                if (contador != 2)
                {
                    throw new PaisException("El partido necesita 2 seleciones");
                }
                nuevo.PartidoSelecciones = pubAutors;

                Contexto.Partido.Add(nuevo);
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
