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
    public class RepositorioPaises : IRepositorioPaises
    {
        public LibreriaContext Contexto { get; set; }

        public static List<Pais> Paises { get; set; } = new List<Pais>();


        public RepositorioPaises(LibreriaContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(Pais obj)
        {
            try
            {
               
                Contexto.Paises.Add(obj);
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

        public IEnumerable<Pais> FindAll()
        {
            return Contexto.Paises
                   .Include(pa => pa.Region)
                   //.Include(au => au.PublicacionesAutor)
                   //.ThenInclude(pa => pa.Publicacion)
                   .ToList();
        }

        public Pais FindById(int id)
        {
            return Contexto.Paises.Where(pa => pa.Id == id).SingleOrDefault();
        }

        public void Remove(int id)
        {
           
            
                Pais aBorrar = Contexto.Paises.Find(id);
                if (aBorrar == null) throw new Exception("No existe dicho pais a borrar");
                Contexto.Paises.Remove(aBorrar);
                Contexto.SaveChanges();

            
        }

        public void Update(Pais obj)
        {
            Contexto.Paises.Update(obj);
            Contexto.SaveChanges();
        }

        public IEnumerable<Pais> ObtainRegion()
        {
            throw new NotImplementedException();
        }

    }
}
