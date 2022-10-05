using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class ListadoRegiones : IListadoRegion
    {
        public IRepositorioRegion RepoRegion { get; set; }

        public ListadoRegiones(IRepositorioRegion reporegion)
        {
            RepoRegion = reporegion;
        }

        public IEnumerable<Region> ObtenerListado()
        {
            return RepoRegion.FindAll();
        }

    }
}
