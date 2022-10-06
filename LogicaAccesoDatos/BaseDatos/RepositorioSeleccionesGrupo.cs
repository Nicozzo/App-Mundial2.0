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
    public class RepositorioSeleccionesGrupo : IRepositorioSeleccionesGrupo
    {

        public LibreriaContext Contexto { get; set; }

        public static List<SeleccionesGrupo> SeleccionGrupo { get; set; } = new List<SeleccionesGrupo>();


        public RepositorioSeleccionesGrupo(LibreriaContext contexto)
        {
            Contexto = contexto;
        }
        public void Add(SeleccionesGrupo obj)
        {
            int contador = 0;
            try
            {
                SeleccionGrupo = Contexto.SeleccionesGrupo
                   .Include(sg => sg.seleccion)
                   .Include(sg => sg.Grupo)
                   .ToList();

                foreach (var item in SeleccionGrupo)
                {
                    if (item.Idseleccion == obj.Idseleccion)
                    {
                        throw new PaisException("La seleccion ya tiene grupo");
                    }

                    if (item.IdGrupo == obj.IdGrupo)
                    {
                        contador++;
                    }

                    if (contador >= 4)
                    {
                        throw new PaisException("GRUPO LLENO!! (El grupo ya tiene 4 Selecciones)");
                    }

                }
                Contexto.SeleccionesGrupo.Add(obj);
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

        public IEnumerable<SeleccionesGrupo> FindAll()
        {
            return Contexto.SeleccionesGrupo
                   .Include(sg => sg.seleccion)
                   .Include(sg => sg.Grupo)
                   .ToList();
        }
    

        public SeleccionesGrupo FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SeleccionesGrupo obj)
        {
            throw new NotImplementedException();
        }
    }
}
