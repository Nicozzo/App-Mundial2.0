using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Dominio;

namespace LogicaAplicacion.InterfacesCU
{
   public interface IListadoPais
    {
        IEnumerable<Pais> ObtenerListado();

    }
}
