using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.Dominio
{
    public class Fase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        private int id;
    }
}
