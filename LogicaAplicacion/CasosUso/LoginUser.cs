using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class LoginUser : ILoginUser
    {
        public static LoginUser Instance { get; set; }
        public User SessionUser { get; set; }
        public IRepositorioUser RepoUser { get; set; }

        public LoginUser(IRepositorioUser repoUser)
        {
            RepoUser = repoUser;
        }

        //public User getInstancia()
        //{
        //    if (Instance.SessionUser == null)
        //    {
        //        return Instance.SessionUser;
        //    }
        //    else { 
                
        //    }
        //}

        public void Logout()
        {
            Instance.SessionUser = null;

        }

        public User Login(string email, string pass)
        {
            User u = null;
            foreach (User user in RepoUser.FindAll())
            {
                if (user.Email.Equals(email) && user.Password.Equals(pass))
                {
                    u = RepoUser.FindByEmail(user.Email);
                    Instance.SessionUser = u;
                    break;
                }
            }
            return u;
        }

        public bool IsLogged()
        {
            return !(Instance.SessionUser == null);
        }

    }

} 




