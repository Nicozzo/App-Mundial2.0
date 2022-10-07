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
    public class RepositorioPartido : IRepositorioPartido
    {

        public LibreriaContext Contexto { get; set; }

        public static List<Partido> Selecciones { get; set; } = new List<Partido>();


        public RepositorioPartido(LibreriaContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(Partido obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Partido> FindAll()
        {
            throw new NotImplementedException();
        }

        public Partido FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Partido obj)
        {
            throw new NotImplementedException();
        }
    }
}
