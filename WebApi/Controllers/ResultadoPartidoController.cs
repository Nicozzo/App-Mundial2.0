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
    public class ResultadoPartidoController : ControllerBase
    {

        public IRepositorioResultadoPartido RepoResulPartido { get; set; }

        public ResultadoPartidoController(IRepositorioResultadoPartido repo)
        {
            RepoResulPartido = repo;
        }
        // GET: api/<ResultadoPartidoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(RepoResulPartido.FindAll());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<ResultadoPartidoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResultadoPartidoController>
        [HttpPost]
        public IActionResult Post([FromBody] ResultadoPartido nuevo)
        {
            try
            {
                RepoResulPartido.Add(nuevo);
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

        // PUT api/<ResultadoPartidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResultadoPartidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
