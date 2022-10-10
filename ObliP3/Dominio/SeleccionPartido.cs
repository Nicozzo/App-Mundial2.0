using Excepciones;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace LogicaNegocio.Dominio
{
    public class SeleccionPartido
    {
        [Key]
        [Column(Order = 1)]
        public int idSeleccion { get; set; }

        [Key]
        [Column(Order = 2)]
        public int idPartido { get; set; }

        [ForeignKey("idSeleccion")]
        public Seleccion Seleccion { get; set; }

        [ForeignKey("idPartido")]
        public Partido Partido { get; set; }
    }
}
