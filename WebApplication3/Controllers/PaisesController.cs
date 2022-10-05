using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicaNegocio.Dominio;
using LogicaAplicacion.InterfacesCU;
using Excepciones;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PaisesController : Controller
    {

        public IAltaPais CUAltaPais { get; set; }
        public IListadoPais CUListaPais { get; set; }
        public IListadoRegion CUListaRegion { get; set; }

        public IBuscarID CUBuscarxID { get; set; }
        public IActualizarPais CUActualizarPais { get; set; }





        public PaisesController(IAltaPais cuAlta,   IListadoPais cuLista, IBuscarID cuBuscar, IActualizarPais cuActualizarPais, IListadoRegion cuListadoRegion)
        {
            CUBuscarxID = cuBuscar;
            CUAltaPais = cuAlta;
            CUListaPais = cuLista;
            CUActualizarPais = cuActualizarPais;
            CUListaRegion = cuListadoRegion;
        }

        public ActionResult Index()
        {
            IEnumerable<Pais> paises = CUListaPais.ObtenerListado();
            return View(paises);
        }

        // GET: PaisesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaisesController/Create
        [HttpGet]
        public ActionResult Create()
        {
            RegionModel rm = new RegionModel();
            rm.Regiones = CUListaRegion.ObtenerListado();
            return View(rm);
        }

        // POST: PaisesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegionModel nuevo)
        {
            try
            {
                Pais pais = nuevo.Pais;
                pais.IdRegion = nuevo.IdRegionSeleccionada;
                CUAltaPais.Alta(pais);
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
             return View();
        }

        // POST: PaisesController/Delete/5
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
