﻿using LogicaAplicacion.InterfacesCU;
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

        //}
        //public IActionResult Logout()
        //{
        //    //if (instance.IsLoggedIn())
        //    //{
        //    //    instance.Logout();
        //    //    HttpContext.Session.Clear();
        //    //    return RedirectToAction("Index", "Dish");
        //    //}
        //    //else
        //    //{
        //    //    return RedirectToAction("Index", "Dish");
        //    //}
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            //if (!CULoginUser.IsLogged())
            //{
                User buscado = CULoginUser.Login(email, password);
                if (buscado != null)
                {
                    HttpContext.Session.SetString("LogueadoEmail", buscado.Email);
                    HttpContext.Session.SetString("LogueadoRol", buscado.Rol);
                    return RedirectToAction("Create", "Paises");
                }
                else
                {
                    ViewBag.msg = "Error en los datos";
                    return View();
                }
            //}
            //else
            //{
            //    return Forbid();
            //}

        }
    }
}


