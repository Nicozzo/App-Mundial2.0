using System.Text;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using System.Linq;
using Excepciones;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace LogicaAccesoDatos.BaseDatos
{
    public class RepositorioResultadoPartido : IRepositorioResultadoPartido
    {
        public LibreriaContext Contexto { get; set; }

        public static List<ResultadoPartido> ResultadoPartido { get; set; } = new List<ResultadoPartido>();


        public RepositorioResultadoPartido(LibreriaContext contexto)
        {
            Contexto = contexto;
        }
        public void Add(ResultadoPartido obj)
        {
            try
            {
                ResultadoPartido = Contexto.ResultadoPartidos
                      //.Include(rp => rp.seleccionPartido)
                      .ToList();

                //foreach (var item in ResultadoPartido)
                //{
                //    if (item.idseleccionPartido == obj.idseleccionPartido)
                //    {
                //        throw new PaisException("Ya ingresaron resultado de esa seleccion en ese partido");
                //    }

                //}


                 

                Contexto.ResultadoPartidos.Add(obj);
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

        public IEnumerable<ResultadoPartido> FindAll()
        {
            return Contexto.ResultadoPartidos
                      //.Include(rp => rp.seleccionPartido)
                      .ToList();
        }

        public ResultadoPartido FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ResultadoPartido obj)
        {
            throw new NotImplementedException();
        }

        
    }
}
