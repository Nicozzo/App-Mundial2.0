using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicaNegocio.Dominio
{
    [Table("User")]
    public class User
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;

        private Rol rol;

        [Required]
        private string username;

        [Required]
        private string password;


    }
}
