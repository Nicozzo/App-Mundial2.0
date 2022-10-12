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
                int contador = 0;

              
                List<SeleccionPartido> selecciones = new List<SeleccionPartido>();
                 selecciones = Contexto.SeleccionPartidos.ToList();

                List<ResultadoPartido> resultadoPartidos = new List<ResultadoPartido>();
                resultadoPartidos = Contexto.ResultadoPartidos.ToList();

                Incidencia nuevo = new Incidencia();
                nuevo.idpartido = obj.idpartido;
                List<ResultadoPartido> resultadoPartido = new List<ResultadoPartido>();
                List<Partido> partidos = new List<Partido>();
                partidos = Contexto.Partido
                 .ToList();
                foreach (var item in partidos){ 
                    if (item.ID == obj.idpartido)
                    {
                        nuevo.Partido = item;
                    }

                }
               
                foreach (var item in obj.resultados)
                {
                
                    contador++;
                    ResultadoPartido rp = new ResultadoPartido();
                    rp.goles = item.goles;
                    rp.rojas = item.rojas;
                    rp.Amarrillas = item.Amarrillas;
                    rp.dobleAmarrilla = item.dobleAmarrilla;
                    rp.idseleccion = item.idseleccion;

                    resultadoPartido.Add(rp);
                }
               
                if (contador != 2)
                {
                    throw new PaisException("Solo pueden haber dos resultados por partido");


                }

                nuevo.resultados = resultadoPartido;


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
