using Excepciones;
using LogicaNegocio.Dominio;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class seleccionesGrupoController : ControllerBase
    {

        public IRepositorioSeleccionesGrupo RepoSeleccionGrupo { get; set; }


        public seleccionesGrupoController(IRepositorioSeleccionesGrupo repo)
        {
            RepoSeleccionGrupo = repo;
        }

        // GET: api/<seleccionesGrupoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(RepoSeleccionGrupo.FindAll());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<seleccionesGrupoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<seleccionesGrupoController>
        [HttpPost]
        public IActionResult Post([FromBody] SeleccionesGrupo value)
        {
            try
            {
                RepoSeleccionGrupo.Add(value);


            }
            catch (PaisException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }


            return CreatedAtRoute("Get", new { id = value.ID }, value);
        }

        // PUT api/<seleccionesGrupoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<seleccionesGrupoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
