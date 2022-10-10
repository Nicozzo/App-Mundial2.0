using Excepciones;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.Dominio
{
    [Table("Partido")]
    public class Partido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [ForeignKey("idSelccionLocal")]
        public int idSelccionLocal { get; set; }

        [ForeignKey("idSelccionVisitante")]
        public int idSelccionVisitante { get; set; }

        public virtual Seleccion SeleccionLocal { get; set; }
        public virtual Seleccion SeleccionVisitante { get; set; }

        public DateTime date { get; set; }


    }
}

