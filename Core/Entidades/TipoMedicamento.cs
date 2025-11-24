using System.ComponentModel.DataAnnotations;

namespace PVeterianaria.Core.Entidades
{
    public class TipoMedicamento
    {
        [Key]
        public int IDTipoMedicamento { get; set; }
        [Required]
        [StringLength(25)]
        public string NombreTipo { get; set; }

        //relacion con la tabla medicamento
        //public ICollection<Medicamento> medicamento { get; set; } = new List<Medicamento>();
    }
}
