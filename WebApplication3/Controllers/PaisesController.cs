using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicaNegocio.Dominio;
using LogicaAplicacion.InterfacesCU;
using Microsoft.AspNetCore.Hosting;
using Excepciones;
using WebApplication3.Models;
using System.IO;

namespace WebApplication3.Controllers
{
    public class PaisesController : Controller
    {

        public IAltaPais CUAltaPais { get; set; }
        public IListadoPais CUListaPais { get; set; }
        public IListadoRegion CUListaRegion { get; set; }
        public IBuscarIDPais CUBuscarxID { get; set; }
        public IActualizarPais CUActualizarPais { get; set; }
        public IWebHostEnvironment WHEnv { get; set; }

        public IBorrarPais CUBorrarPais { get; set; }


        public PaisesController(IAltaPais cuAlta,   IListadoPais cuLista, IBuscarIDPais cuBuscar, IActualizarPais cuActualizarPais, IListadoRegion cuListadoRegion, IWebHostEnvironment whenv, IBorrarPais cuBorrar)
        {
            CUBuscarxID = cuBuscar;
            CUAltaPais = cuAlta;
            CUListaPais = cuLista;
            CUActualizarPais = cuActualizarPais;
            CUListaRegion = cuListadoRegion;
            CUBorrarPais = cuBorrar;
            WHEnv = whenv;
        }

        public ActionResult Index()
        {
            IEnumerable<Pais> paises = CUListaPais.ObtenerListado();
            return View(paises);
        }

        // GET: PaisesController/Create
        [HttpGet]
        public ActionResult Create()
        {
            if (HttpContext.Session.GetString("LogueadoEmail") != null)
            {
                WebApplication3.Models.RegionViewModel rm = new RegionViewModel();
                rm.Regiones = CUListaRegion.ObtenerListado();
                return View(rm);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: PaisesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegionViewModel rm)
        {
            try
            {
                Pais pais = rm.Pais;
                pais.IdRegion = rm.IdRegionSeleccionada;

                foreach (Region item in CUListaRegion.ObtenerListado())
                {
                    if (item.IdRegion == pais.IdRegion)
                    {
                        pais.Region = item;
                    }
                }

                FileInfo fi = new FileInfo(rm.Imagen.FileName);

                string ext = fi.Extension;

                string nomArchivo = rm.Pais.Nombre + ext;


                pais.Imagen = nomArchivo;

                CUAltaPais.Alta(pais);

                string rutaWebApp = WHEnv.WebRootPath;

                string rutaCarpeta = Path.Combine(rutaWebApp, "img");

                string rutaArchivo = Path.Combine(rutaCarpeta, nomArchivo);

                FileStream fs = new FileStream(rutaArchivo, FileMode.Create);

                rm.Imagen.CopyTo(fs);

                return RedirectToAction("Index", "Paises");
            }
            catch (PaisException e)
            {
                ViewBag.Error = e.Message;
                rm.Regiones = CUListaRegion.ObtenerListado();
                return View(rm);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                rm.Regiones = CUListaRegion.ObtenerListado();
                return View(rm);
            }
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("LogueadoEmail") != null)
            {
                Pais aEditar = CUBuscarxID.BuscarId(id);
                RegionViewModel rm = new RegionViewModel();
                rm.Pais = aEditar;
                rm.Regiones = CUListaRegion.ObtenerListado();
                try
                {
                    if (aEditar == null)
                    {
                        ViewBag.Error = "El Pais no existe";
                        rm.Regiones = CUListaRegion.ObtenerListado();
                        return View(rm);
                    }

                    return View(rm);
                }
                catch (Exception ex)
                {
                    ViewBag.Error = "Ocurrió un error: " + ex.Message;

                    rm.Regiones = CUListaRegion.ObtenerListado();
                    return View(rm);
                }
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RegionViewModel rm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    rm.Pais.IdRegion = rm.IdRegionSeleccionada;

                    foreach (Region item in CUListaRegion.ObtenerListado())
                    {
                        if (item.IdRegion == rm.Pais.IdRegion)
                        {
                            rm.Pais.Region = item;
                            break;
                        }
                    }

                    if (rm.Imagen != null)
                    {
                        FileInfo fi = new FileInfo(rm.Imagen.FileName);

                        string ext = fi.Extension;

                        string nomArchivo = rm.Pais.Nombre + ext;

                        rm.Pais.Imagen = nomArchivo;
                    }

                    CUActualizarPais.Actualizar(rm.Pais);

                    return RedirectToAction("Index", "Paises");
                }
                else
                {
                    ViewBag.Error = "Datos inválidos. Por favor revise los datos ingresados";
                    return View();
                }
            }
            catch (PaisException e)
            {
                ViewBag.Error = "Error: " + e.Message;
                rm.Regiones = CUListaRegion.ObtenerListado();
                return View(rm);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Ocurrió un error";
                rm.Regiones = CUListaRegion.ObtenerListado();
                return View(rm);
            }
        }

        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("LogueadoEmail") != null)
            {
                Pais aBorrar = CUBuscarxID.BuscarId(id);
                CUBorrarPais.BorrarPais(aBorrar);
                return RedirectToAction("Index", "Paises");
                
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

    }
}
