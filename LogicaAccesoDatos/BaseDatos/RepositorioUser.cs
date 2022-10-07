using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaAccesoDatos.BaseDatos
{
    public class RepositorioUser : IRepositorioUser
    {
        public LibreriaContext Contexto { get; set; }

        public static List<User> Users { get; set; } = new List<User>();


        public RepositorioUser(LibreriaContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(User obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> FindAll()
        {
            return Contexto.Users;
        }

        public User FindByEmail(string mail)
        {
            return Contexto.Users.Where(pa => pa.Email == mail).ToList().SingleOrDefault();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
