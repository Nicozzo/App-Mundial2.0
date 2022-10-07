using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LogicaNegocio.InterfacesDominio;
using System.Linq;
using Excepciones;

namespace LogicaNegocio.Dominio
{
    [Table("SeleccionPartidos")]
    public class SeleccionPartidos
    {
        public int id { get; set; }
        
        [ForeignKey("idseleccion")]
        public Seleccion Seleccion { get; set; }
        public int idseleccion { get; set; }

        [ForeignKey("idpartido")]
        public Partido partido { get; set; }
        public int idpartido { get; set; }


    }
}
