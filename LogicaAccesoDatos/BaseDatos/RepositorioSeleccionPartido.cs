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
    public class RepositorioSeleccionPartido : IRepositorioSeleccionPartidos
    {

        public LibreriaContext Contexto { get; set; }

        public static List<SeleccionPartidos> SeleccionesPartido { get; set; } = new List<SeleccionPartidos>();


        public RepositorioSeleccionPartido(LibreriaContext contexto)
        {
            Contexto = contexto;
        }
        public void Add(SeleccionPartidos obj)
        {
            try
            {
                SeleccionesPartido = Contexto.SeleccionPartidos
                    .Include(sp => sp.partido)
                    .Include(sp => sp.Seleccion)
                    .ToList();
                
                List<Seleccion> selecciones = new List<Seleccion>();
                selecciones = Contexto.Seleccion
                                .ToList();
                Seleccion aux = null;
                foreach (var item in selecciones)
                {
                    if (item.ID == obj.idseleccion )
                    {
                        aux = item;
                    }
                }



                foreach (var item in SeleccionesPartido)
                {
                    if (item.idpartido == obj.idpartido)
                    {
                        if (item.idseleccion == obj.idseleccion)
                        {
                            throw new PaisException("La seleccion no puede jugar contra ella misma");
                        }
                        if (item.Seleccion.IdGrupo != aux.IdGrupo)
                    {
                        throw new PaisException("Las selecciones no estan en el mismo grupo");
                    }

                }

                    if (item.idseleccion != obj.idseleccion)
                    {
                        if (item.idpartido == obj.idpartido)
                        {
                            throw new PaisException("Ya Jugaron Entre ellos");
                        }
                    }
            }
            Contexto.SeleccionPartidos.Add(obj);
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

        public IEnumerable<SeleccionPartidos> FindAll()
        {
            return Contexto.SeleccionPartidos
                    .Include(sp => sp.partido)
                    .Include(sp => sp.Seleccion)
                    .ToList();
        }

        public SeleccionPartidos FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(SeleccionPartidos obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
