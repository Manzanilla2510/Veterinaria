using System.ComponentModel.DataAnnotations;

namespace PVeterianaria.Core.Entidades
{
    public class Medicamento
    {
        [Key]
        public int IdMedicamento { get; set; }
        //FK de la tabla TipoMedicamento
        //public int IdTipoMedicamento { get; set; }
        //public TipoMedicamento TipoMediamento { get; set; }

        [Required]
        [StringLength(25)]
        public string CodigoMedicamento { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }

        [Required]
        public DateOnly FechaVencimiento { get; set; }
        [Required]
        public int Cantidad { get; set; }

        [Required]
        [StringLength(25)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(25)]
        public string Estado { get; set; }

        //relacion con la tabla revision muchos a muchos 
        //public ICollection<RevisionMedicamento> revisionMedicamentos { get; set; } = new List<RevisionMedicamento>();
    }
}
