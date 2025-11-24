using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVeterianaria.Core.Entidades
{
    public class ProduccionLeche
    {
        [Key]
        public int IdProduccionLeche { get; set; }
        //public int IdAnimal { get; set; }
        //public Animal Animal { get; set; }
        [Required]
        public DateOnly Fecha_produccion { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Cantidad_Leche { get; set; }
    }
}
