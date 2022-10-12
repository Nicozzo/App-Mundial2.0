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
    public class RepositorioIncidencia : IRepositorioIncidencia
    {
        public LibreriaContext Contexto { get; set; }

        public static List<Incidencia> Incidencia { get; set; } = new List<Incidencia>();


        public RepositorioIncidencia(LibreriaContext contexto)
        {
            Contexto = contexto;

        }
        public void Add(Incidencia obj)
        {
            try
            {

                Incidencia = Contexto.incidencias
                  .ToList();
                List<SeleccionPartido> selecciones = new List<SeleccionPartido>();
                 selecciones = Contexto.SeleccionPartidos.ToList();

                List<ResultadoPartido> resultadoPartidos = new List<ResultadoPartido>();
                resultadoPartidos = Contexto.ResultadoPartidos.ToList();
                int contador = 0;
                int aux = 0;
              

               
                Incidencia nuevo = new Incidencia();
                

                List<ResultadoPartido> resultadoPartido = new List<ResultadoPartido>();
                foreach (var item in obj.resultados)
                {
                    ResultadoPartido rp = new ResultadoPartido();
                    rp.goles = item.goles;
                    rp.rojas = item.rojas;
                    rp.Amarrillas = item.Amarrillas;
                    rp.dobleAmarrilla = item.dobleAmarrilla;
                    rp.idseleccionPartido = item.idseleccionPartido;

                    foreach (var item3 in resultadoPartidos)
                    {
                        if(item3.idseleccionPartido == rp.idseleccionPartido)
                        {
                            throw new PaisException("ya hay un resultado para ese partido");

                        }
                    }
                    foreach (SeleccionPartido item2 in selecciones)
                    {
                        if (item.idseleccionPartido == item2.id)
                        {
                            rp.SeleccionPartido = item2;
                        }
                    }
                    resultadoPartido.Add(rp);
                }

                nuevo.resultados = resultadoPartido;

                

                if (nuevo.resultados.ElementAt(0).SeleccionPartido.idpartido != nuevo.resultados.ElementAt(1).SeleccionPartido.idpartido)
                {
                    throw new PaisException("Estas selecciones no tienen el mismo Partido");
                }
               

                foreach (var item in obj.resultados)
                {
                    contador++;
                 
                }
                if (contador != 2)
                {
                    throw new PaisException("Solo pueden haber dos resultados por partido");


                }

                Contexto.incidencias.Add(nuevo);
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

        public IEnumerable<Incidencia> FindAll()
        {
            return Contexto.incidencias.ToList();
        }

        public Incidencia FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Incidencia obj)
        {
            throw new NotImplementedException();
        }
    }
}
