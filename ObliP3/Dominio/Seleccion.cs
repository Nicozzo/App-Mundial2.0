using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicaNegocio.Dominio
{
    [Table("Seleccion")]
    public class Seleccion
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Email { get; set; }

        public int Telefono { get; set; }

        public int CantApost { get; set; }

        
        public Pais pais { get; set; }
    }
}
