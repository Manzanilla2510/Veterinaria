using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVeterianaria.Core.Entidades
{
    public class Alimentacion
    {
        [Key]
        public int IdAlimentacion { get; set; }
        [Required]
        [StringLength(25)]
        public string CodigoAnimal { get; set; }
        [Required]
        [StringLength(25)]
        public string NombreAlimento { get; set; }
        [Required]
        [StringLength(25)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(25)]
        public string Descripcion { get; set; }
        public DateOnly Fecha { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Cantidad { get; set; }
        [Required]
        [StringLength(25)]
        public string Estado { get; set; }
    }
}
