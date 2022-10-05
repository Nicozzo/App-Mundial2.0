using LogicaNegocio.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LogicaAccesoDatos.BaseDatos
{
    public class RepositorioRegion : IRepositorioRegion
    {
        public LibreriaContext Contexto { get; set; }

        public static List<Region> Regiones { get; set; } = new List<Region>();
        public RepositorioRegion(LibreriaContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(Region obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Region obj)
        {
            throw new NotImplementedException();
        }

        public Region FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Region> FindAll()
        {
            return Contexto.Regiones;
            //.Include(re => re.Paises)
            //.ToList();
        }


    }
}
