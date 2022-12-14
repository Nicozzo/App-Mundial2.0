using Excepciones;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.Dominio
{
    [Table("ResultadoPartido")]
    public class ResultadoPartido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        
        [ForeignKey("idseleccion")]
        public Seleccion seleccion { get; set; }
        public int idseleccion { get; set; }

        public int goles{ get; set; }
        
        public int rojas { get; set; }
       
        public int dobleAmarrilla { get; set; }
        
        public int Amarrillas{ get; set; }
        

    }
}
