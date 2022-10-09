using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using LogicaAplicacion.InterfacesCU;

namespace LogicaAplicacion.CasosUso

{
    public class BorrarPais : IBorrarPais
    {
        public IRepositorioPaises RepoPaises { get; set; }

        public BorrarPais(IRepositorioPaises repoPaises)
        {
            RepoPaises = repoPaises;
        }

        void IBorrarPais.BorrarPais(Pais pa)
        {
            RepoPaises.Remove(pa.Id);
        }
    }
}