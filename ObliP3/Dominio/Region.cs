using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.Dominio
{
    public class Region
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get;   set; }
        public string NombreCont { get; set; }

        public string CodigoIso { get; set; }

        public string Nombre { get; set; }
    }
}
