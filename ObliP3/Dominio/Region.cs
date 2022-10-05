using Excepciones;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.Dominio
{
    public class Region  : IValidable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdRegion { get;   set; }

        
        [Required]
        public string Nombre { get; set; }

        public List<Pais> Paises { get; set; }

        public void Validar()
        {
            NombreValido();
        }

        private void NombreValido()
        {
            Nombre = Nombre.ToLower();
            if (Nombre != "áfrica" || Nombre != "américa" || Nombre != "asia" || Nombre != "europa" || Nombre != "oceanía") {
                throw new RegionException("La región debe existir (continente");
            }
        }
    }
}
