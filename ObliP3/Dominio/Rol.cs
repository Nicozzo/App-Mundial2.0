using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicaNegocio.Dominio
{
    [Table("Rol")]
    public class Rol
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;

        private string nombre;

    }
}
