using LogicaAplicacion.CasosUso;
using LogicaNegocio.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.InterfacesCU
{
    public interface ILoginUser
    {

        //User getInstancia();

        User Login(string email, string pass);

        void Logout();

        bool IsLogged();
    }
}
