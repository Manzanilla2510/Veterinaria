using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVeterianaria.Core.Entidades
{
    public class Veterinario
    {
        [Key]
        public int IdVeterinario { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }
        [Required]
        [StringLength(50)]
        public string Ci { get; set; }
        [Required]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Sueldo { get; set; }
        [Required]
        [StringLength(50)]
        public string Estado { get; set; } = "Activo";

        //relacion con la tala revision
        //public ICollection<Revision> revisiones { get; set; } = new List<Revision>();
    }
}
