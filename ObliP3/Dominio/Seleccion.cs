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

        [ForeignKey("IdPais")]
        public Pais Pais { get; set; }
        public int IdPais { get; set; }

        [ForeignKey("IdGrupo")]
        public Grupo Grupo { get; set; }
        public int IdGrupo { get; set; }
    }
}
