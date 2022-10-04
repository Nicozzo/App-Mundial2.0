using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LogicaNegocio.Dominio
{
    [Table("Pais")]
    public class Pais : IComparable<Pais>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        [ Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        [MaxLength(3), Required(ErrorMessage = "El nombre es obligatorio")]
        public string CodigoIso { get; set; }

        public int Pbi { get; set; }

        public int Poblacion { get; set; }

        public string Imagen { get; set; }

        public Region Region { get; set; }

        [ForeignKey("Region")]
        public int IdRegion { get; set; }

        public int CompareTo([AllowNull] Pais other)
        {
            throw new NotImplementedException();
        }
    }

   
}
