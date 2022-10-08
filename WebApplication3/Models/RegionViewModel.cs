using LogicaNegocio.Dominio;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication3.Models
{
    public class RegionViewModel
    {
        public IEnumerable<Region> Regiones { get; set; }
        public Pais Pais { get; set; }
        public int IdRegionSeleccionada { get; set; }
        public IFormFile Imagen { get; set; }
    }
}
