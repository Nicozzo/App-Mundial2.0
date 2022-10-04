using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Dominio;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioSeleccion : IRepositorio<Seleccion>
    {
        IEnumerable<Seleccion> ObtainPais();
    }
}
