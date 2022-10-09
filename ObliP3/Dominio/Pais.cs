using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LogicaNegocio.InterfacesDominio;
using System.Linq;
using Excepciones;

namespace LogicaNegocio.Dominio
{
    [Table("Pais")]
    public class Pais : IComparable<Pais>, IValidable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        [MaxLength(3), Required(ErrorMessage = "El nombre es obligatorio")]
        public string CodigoIso { get; set; }

        public int Pbi { get; set; }

        public int Poblacion { get; set; }

        public string Imagen { get; set; }

        [ForeignKey("IdRegion")]
        public Region Region { get; set; }
        public int IdRegion { get; set; }


        public int CompareTo([AllowNull] Pais other)
        {
            throw new NotImplementedException();
        }

        public void Validar()
        {
            NombreValido();
            CodigoValido();
            NumerosValidos();
        }

        public void NumerosValidos() {

            if (Pbi <= 0 || Poblacion <= 0) {
                throw new PaisException("Los números deben ser positivos");
            }
        }
        public void NombreValido() {

            this.Nombre.Trim();
            if (!Nombre.Any(ch => Char.IsLetterOrDigit(ch))) { 
                throw new PaisException("El nombre solo puede contener letras y espacios embebidos");
            }
        }

        public void CodigoValido()
        {

            this.CodigoIso.Trim();
            if (!CodigoIso.StartsWith(Nombre.Substring(0, 1))) { 
                throw new PaisException("El codigo debe comenzar con la primer letra del nombre del pais");
            }
        }

    }

   
}
