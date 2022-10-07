using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Excepciones;

namespace LogicaNegocio.Dominio
{
    [Table("Seleccion")]
    public class Seleccion
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Email { get; set; }

        public int Telefono { get; set; }

        public int CantApost { get; set; }

        [ForeignKey("IdPais")]
        public Pais Pais { get; set; }
        public int IdPais { get; set; }

        [ForeignKey("IdGrupo")]
        public Grupo Grupo { get; set; }
        public int IdGrupo { get; set; }

        public void Validar()
        {
            MailValido();


        }

        public void MailValido()
        {
            if (Email == null)
            {
                throw new SeleccionException("Los números deben ser positivos");

            }
            else
            {
                if (Email.IndexOf("@") != -1 && Email.IndexOf("@") != 0 && Email.IndexOf("@") != Email.Length - 1 && Email.Contains(".")) { 
                throw new SeleccionException("Los números deben ser positivos");
                }
            }
        }



    }
}
