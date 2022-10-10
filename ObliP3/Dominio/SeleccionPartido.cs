using Excepciones;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace LogicaNegocio.Dominio
{
    [Table("SeleccionPartido")]
    public class SeleccionPartido
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("idseleccion")]
        public Seleccion Seleccion { get; set; }
        public int idseleccion { get; set; }

        [ForeignKey("idpartido")]
        public Partido partido { get; set; }
        public int idpartido { get; set; }
<<<<<<< HEAD:ObliP3/Dominio/SeleccionPartidos.cs

=======
>>>>>>> 4ef9c60519bed922045224548ab87289e5d491bb:ObliP3/Dominio/SeleccionPartido.cs
    }
}
