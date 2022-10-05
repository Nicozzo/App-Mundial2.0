using LogicaNegocio.Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicaNegocio.InterfacesRepositorios;
using Excepciones;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeleccionesController : ControllerBase
    {
        public IRepositorioSeleccion RepoSeleccion { get; set; }

        public SeleccionesController(IRepositorioSeleccion repo)
        {
            RepoSeleccion = repo;
        }
        // GET: api/<SeleccionesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(RepoSeleccion.FindAll());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<SeleccionesController>/5
        [Route("{id}", Name = "Get")]
        [HttpGet("{id}")]
        public IActionResult Get(int? id)
        {
            if (id == null || id == 0) return BadRequest();

            try
            {
                Seleccion buscado = RepoSeleccion.FindById(id.Value);
                if (buscado == null) return NotFound();
                return Ok(buscado);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // POST api/<SeleccionesController>
        [HttpPost]
        public IActionResult Post([FromBody] Seleccion nuevo)
        {
            try
            {
                RepoSeleccion.Add(nuevo);
            }
            catch (PaisException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }


            return CreatedAtRoute("Get", new { id = nuevo.ID }, nuevo);
        }

        // PUT api/<SeleccionesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Seleccion edit)
        {
            if (id == 0 || id != edit.ID) return BadRequest();

            try
            {
                RepoSeleccion.Update(edit);
                return Ok(edit);
            }
            catch (PaisException ex)
            {
                return BadRequest(ex.Message);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<SeleccionesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest("El id no puede ser 0");
            try
            {
                RepoSeleccion.Remove(id);
                return NoContent();
            }
            catch (PaisException ex)
            {
                return BadRequest(ex.Message);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}