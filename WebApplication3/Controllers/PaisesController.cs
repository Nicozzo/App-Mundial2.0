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


        public PaisesController(IAltaPais cuAlta,   IListadoPais cuLista, IBuscarIDPais cuBuscar, IActualizarPais cuActualizarPais, IListadoRegion cuListadoRegion, IWebHostEnvironment whenv)
        {
            CUBuscarxID = cuBuscar;
            CUAltaPais = cuAlta;
            CUListaPais = cuLista;
            CUActualizarPais = cuActualizarPais;
            CUListaRegion = cuListadoRegion;
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
                RegionViewModel rm = new RegionViewModel();
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
        public ActionResult Create(RegionViewModel nuevo)
        {
            try
            {
                Pais pais = nuevo.Pais;
                pais.IdRegion = nuevo.IdRegionSeleccionada;
               
                foreach (Region item in CUListaRegion.ObtenerListado())
                {
                    if (item.IdRegion == pais.IdRegion) {
                        pais.Region = item;
                    }
                }

                FileInfo fi = new FileInfo(nuevo.Imagen.FileName);

                string ext = fi.Extension;

                string nomArchivo = nuevo.Pais.Nombre + ext;


                pais.Imagen = nomArchivo;
                
                CUAltaPais.Alta(pais);
              

                string rutaWebApp = WHEnv.WebRootPath;

                string rutaCarpeta = Path.Combine(rutaWebApp, "img");

                string rutaArchivo = Path.Combine(rutaCarpeta, nomArchivo);

                FileStream fs = new FileStream(rutaArchivo, FileMode.Create);


                nuevo.Imagen.CopyTo(fs);

                return RedirectToAction("Index", "Paises");
            }
            catch (PaisException e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
            catch (Exception e)
            {
                ViewBag.Error = "Ocurrió un error";
                //loguear la excepción? inner exception?
                return View();
            }
        }

        // GET: PaisesController/Edit/5
        public ActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("LogueadoEmail") != null)
            {
                Pais aEditar = CUBuscarxID.BuscarId(id);

                try
                {
                    if (aEditar == null)
                    {
                        ViewBag.Error = "El Pais no existe";
                        return View();
                    }

                    return View(aEditar);
                }
                catch (Exception ex)
                {
                    ViewBag.Error = "Ocurrió un error: " + ex.Message;
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
           
        }

        // POST: PaisesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pais obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CUActualizarPais.Actualizar(obj);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Datos inválidos. Por favor revise los datos ingresados";
                    return View();
                }
            }
            catch (PaisException ex)
            {
                ViewBag.Error = "Error: " + ex.Message;
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Ocurrió un error";
                 
                return View();
            }
        }

        // GET: PaisesController/Delete/5
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("LogueadoEmail") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
