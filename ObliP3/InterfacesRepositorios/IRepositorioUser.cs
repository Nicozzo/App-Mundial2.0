using LogicaNegocio.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioUser : IRepositorio<User>
    {
        User FindByEmail(string email);
    }
}
