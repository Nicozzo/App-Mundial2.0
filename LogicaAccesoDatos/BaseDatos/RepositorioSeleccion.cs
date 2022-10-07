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
            int contador = 0;
            try
            {
                Selecciones = Contexto.Seleccion
                   .Include(se => se.Pais)
                   .Include(se => se.Grupo)
                   .ToList();

                foreach (var item in Selecciones)
                {
                    if (item.IdPais == obj.IdPais)
                    {
                        throw new PaisException("El Pais ya tiene una seleccion Asignada");
                    }
                    if (item.IdGrupo == obj.IdGrupo)
                    {
                        contador++;
                    }
                    if (contador >= 4)
                    {
                        throw new PaisException("El Grupo ya tiene 4 selecciones");
                    }
                }
                Contexto.Seleccion.Add(obj);

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

        public IEnumerable<Seleccion> FindAll()
        {
            return Contexto.Seleccion
                   .Include(se => se.Pais)
                   .Include(se => se.Grupo)
                   .ToList();
        }

        public Seleccion FindById(int id)
        {
            return Contexto.Seleccion.Where(se => se.ID == id).SingleOrDefault();
        }

        public IEnumerable<Seleccion> ObtainPais()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {

            Seleccion aBorrar = Contexto.Seleccion.Find(id);
            if (aBorrar == null) throw new Exception("No existe dicho pais a borrar");
            Contexto.Seleccion.Remove(aBorrar);
            Contexto.SaveChanges();
        }

        public void Update(Seleccion obj)
        {
            Contexto.Seleccion.Update(obj);
            Contexto.SaveChanges();
        }
    }
}
