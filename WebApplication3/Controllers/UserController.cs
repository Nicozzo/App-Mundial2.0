using LogicaAplicacion.InterfacesCU;
using LogicaNegocio.Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class UserController : Controller
    {

        public ILoginUser CULoginUser { get; set; }


        public UserController(ILoginUser CULogin)
        {
            CULoginUser = CULogin;
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("LogueadoEmail") != null)
            {
                CULoginUser.Logout();
                HttpContext.Session.Clear();
                Console.WriteLine(HttpContext.Session.GetString("LogueadoRol"));

                return RedirectToAction("Index", "Paises");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
           
       
        }

        public ActionResult Login()
        {
            if (HttpContext.Session.GetString("LogueadoEmail") == null)
            {
                return View();
            }
            else {
                    return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
                User buscado = CULoginUser.Login(email, password);

                if (buscado != null)
                {
                    HttpContext.Session.SetString("LogueadoEmail", buscado.Email);
                    HttpContext.Session.SetString("LogueadoRol", buscado.Rol);
                    return RedirectToAction("Index", "Paises");
                }
                else
                {
                    ViewBag.msg = "Error en los datos";
                    return View();
                }
            }

        }
}


