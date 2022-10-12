using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Excepciones;

namespace LogicaNegocio.Dominio
{
    [Table("Incidencia")]
    public class Incidencia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public IEnumerable<ResultadoPartido> resultados { get; set; }

        [ForeignKey("idpartido")]
        public Partido Partido { get; set; }
        public int idpartido { get; set; }
        public string Resultado { get; set; }
    }
}
