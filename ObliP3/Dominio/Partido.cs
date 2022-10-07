using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LogicaNegocio.InterfacesDominio;
using System.Linq;
using Excepciones;

namespace LogicaNegocio.Dominio
{
    [Table("Partido")]
    public class Partido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }


        public DateTime date { get; set; }


    }
}
