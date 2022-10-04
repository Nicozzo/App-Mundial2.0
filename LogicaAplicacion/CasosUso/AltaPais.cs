using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using LogicaAplicacion.InterfacesCU;

namespace LogicaAplicacion.CasosUso

{
    public class AltaPais : IAltaPais
    {
        public IRepositorioPaises RepoPaises { get; set; }

        public AltaPais(IRepositorioPaises repoPaises)
        {
            RepoPaises = repoPaises;
        }

        public void Alta(Pais nuevo)
        {
            RepoPaises.Add(nuevo);
        }
    }
}
