using System;
using System.Collections.Generic;
using System.Text;
using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso
{
    public class BuscarUser : IBuscarUser
    {
        public IRepositorioUser RepoUser { get; set; }

        public BuscarUser(IRepositorioUser repo)
        {
            RepoUser = repo;
        }

        public User BuscarId(int id)
        {
            return RepoUser.FindById(id);
        }

    }
}
