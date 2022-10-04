using System;
using System.Collections.Generic;
using System.Text;
using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso
{
    public class ListadoPais : IListadoPais
    {
        public IRepositorioPaises RepoPaises { get; set; }

        public ListadoPais(IRepositorioPaises repoPaises)
        {
            RepoPaises = repoPaises;
        }

        public IEnumerable<Pais> ObtenerListado()
        {
            return RepoPaises.FindAll();
        }
    }
}
