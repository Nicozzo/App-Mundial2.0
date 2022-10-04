using System;
using System.Collections.Generic;
using System.Text;
using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;

namespace LogicaAplicacion.CasosUso
{
   public class ActualizarPais : IActualizarPais
    {
        public IRepositorioPaises RepoPais { get; set; }

        public ActualizarPais(IRepositorioPaises repoPais)
        {
            RepoPais = repoPais;
        }

        public void Actualizar(Pais obj)
        {
            RepoPais.Update(obj);
        }

    }
}
