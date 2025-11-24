using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVeterianaria.Core.Entidades
{
    public class Revision
    {
        [Key]
        public int IdRevision { get; set; } 

        //FK de la tabla IdAnimal
        //public int IdAnimal { get; set; } 
       // public Animal Animal { get; set; }
        //FK de la tabla IdVeterinario
        //public int IdVeterinario { get; set; } 
       // public Veterinario veterinario { get; set; }

        [Required]
        public DateOnly Fecha_Revision { get; set; }

        [Required]
        [StringLength(50)]
        public string Condicion { get; set; }
        [Required]
        public DateOnly FechaRecuperacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Diagnostico { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Temperatura { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PesoActual { get; set; }

        [Required]
        [StringLength(50)]
        public string Tratamiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Observaciones { get; set; }

        //relacion con la tabla revision herramienta y medicamento
        //public ICollection<RevisionHerramienta> revisionHerramientas { get; set; } = new List<RevisionHerramienta>();
        //public ICollection<RevisionMedicamento> revisionMedicamentos { get; set; } = new List<RevisionMedicamento>();
    }
}
