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
    public class SeleccionPartidoController : ControllerBase
    {
        public IRepositorioSeleccionPartido RepoSeleccionPartido { get; set; }

        public SeleccionPartidoController(IRepositorioSeleccionPartido repo)
        {
            RepoSeleccionPartido = repo;
        }
        // GET: api/<SeleccionPartidoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(RepoSeleccionPartido.FindAll());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<SeleccionPartidoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SeleccionPartidoController>
        [HttpPost]
        public IActionResult Post([FromBody] SeleccionPartido nuevo)
        {
            try
            {
                RepoSeleccionPartido.Add(nuevo);
            }
            catch (PaisException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }


            return CreatedAtRoute("Get", new { id = nuevo.id }, nuevo);
        }

        // PUT api/<SeleccionPartidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SeleccionPartidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
