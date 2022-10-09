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
        public User SessionUser { get; set; }
        public IRepositorioUser RepoUser { get; set; }

        public LoginUser(IRepositorioUser repoUser)
        {
            RepoUser = repoUser;
        }

        public User GetInstance()
        {
          return SessionUser;

        }

        public void SetInstance(User user) {

            SessionUser = user;
        }

        public void Logout()
        {
            SessionUser = null;
        }

        public User Login(string email, string pass)
        {
            User u = null;
            foreach (User user in RepoUser.FindAll())
            {
                if (user.Email.Equals(email) && user.Password.Equals(pass))
                {
                    u = RepoUser.FindByEmail(user.Email);
                    break;
                }
            }
            return u;
        }

        public bool IsLogged()
        {
            return !(SessionUser == null);
        }

    }

} 




