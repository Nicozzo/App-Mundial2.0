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
                int aux = 0;
                if (obj.resultados.ElementAt(0) != obj.resultados.ElementAt(1))  
                 {
                    throw new PaisException("Estas selecciones no tienen el mismo Partido");
                }

               
                foreach (var item in obj.resultados)
                {

                    contador++;

                    if (contador != 2)
                    {
                        throw new PaisException("Solo pueden haber dos resultados por partido");


                    }
                }
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
                    resultadoPartido.Add(rp);
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
            return Contexto.incidencias

                    .ToList();
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
