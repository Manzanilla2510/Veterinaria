using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVeterianaria.Core.Entidades
{
    public class Animal
    {
        [Key]
        public int IdAnimal { get; set; }
        [Required]
        [StringLength(25)]
        public string CodigoAnimal { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Peso { get; set; }
        [Required]
        public int Edad { get; set; }

        [Required]
        [StringLength(50)]
        public string Raza { get; set; }

        [Required]
        public DateOnly Fecha_Ingreso { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; } = "Activo";

        //Relaciones con la tabla resvision y produccion
        //public ICollection<Revision>? Revisiones { get; set; } = new List<Revision>();
        //public ICollection<ProduccionLeche> Produccion { get; set; } = new List<ProduccionLeche>();
    }
}
