using System;
using System.Collections.Generic;
using System.Text;
using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso
{
    public class BuscarID : IBuscarID
    {
        public IRepositorioPaises RepoPaises { get; set; }

        public BuscarID(IRepositorioPaises repo)
        {
            RepoPaises = repo;
        }

        public Pais BuscarId(int id)
        {
            return RepoPaises.FindById(id);
        }

    }
}
