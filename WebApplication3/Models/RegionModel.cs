using LogicaNegocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication3.Models
{
    public class RegionModel
    {
        public IEnumerable<Region> Regiones { get; set; }
        public Pais Pais { get; set; }
        public int IdRegionSeleccionada { get; set; }
    }
}
