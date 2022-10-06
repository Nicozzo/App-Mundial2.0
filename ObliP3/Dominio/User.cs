using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicaNegocio.Dominio
{
    [Table("Usuarios")]
    public class User
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        private int id;

        private string rol;

        [Required]
        private string email;

        [Required]
        private string password;


        public int Id { get => id; set => id = value; }

        public string Email { get => email; set => email = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Password { get => password; set => password = value; }
    }
}
