using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicaNegocio.Dominio
{
    [Table("SeleccionesGrupo")]
    public class SeleccionesGrupo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [ForeignKey("Idseleccion")]
        public Seleccion seleccion { get; set; }
        public int Idseleccion { get; set; }

        [ForeignKey("IdGrupo")]
        public Grupo Grupo { get; set; }
        public int IdGrupo { get; set; }
    }
}
