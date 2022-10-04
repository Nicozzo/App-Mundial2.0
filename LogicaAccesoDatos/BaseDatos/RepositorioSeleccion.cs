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
    public class RepositorioSeleccion : IRepositorioSeleccion
    {
        public LibreriaContext Contexto { get; set; }

        public static List<Seleccion> Selecciones { get; set; } = new List<Seleccion>();


        public RepositorioSeleccion(LibreriaContext contexto)
        {
            Contexto = contexto;
        }
        public void Add(Seleccion obj)
        {
            try
            {
                Contexto.Seleccion.Add(obj);
                Contexto.SaveChanges();
            }
            catch (PaisException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo realizar el alta de autor", e);
            }
        }

        public IEnumerable<Seleccion> FindAll()
        {
            throw new NotImplementedException();
        }

        public Seleccion FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Seleccion> ObtainPais()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Seleccion obj)
        {
            throw new NotImplementedException();
        }
    }
}
