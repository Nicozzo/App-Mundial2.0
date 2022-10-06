using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class ListadoUsers : IListadoUsers
    {
        public IRepositorioUser RepoUser { get; set; }

        public ListadoUsers(IRepositorioUser repoUser)
        {
            RepoUser = repoUser;
        }

        public IEnumerable<User> ObtenerListado()
        {
            return RepoUser.FindAll();
        }

    }
}