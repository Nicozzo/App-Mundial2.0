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
    public class PartidosController : ControllerBase
    {

        public IRepositorioPartido RepoPartido { get; set; }

        public PartidosController(IRepositorioPartido repo)
        {
            RepoPartido = repo;
        }
        // GET: api/<PartidosController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(RepoPartido.FindAll());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<PartidosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PartidosController>
        [HttpPost]
        public IActionResult Post([FromBody] Partido nuevo)
        {
            try
            {
                RepoPartido.Add(nuevo);
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

        // PUT api/<PartidosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PartidosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
