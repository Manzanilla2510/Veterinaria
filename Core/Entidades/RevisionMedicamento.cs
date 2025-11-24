using System.ComponentModel.DataAnnotations;

namespace PVeterianaria.Core.Entidades
{
    public class RevisionMedicamento
    {
        [Key]
        public int IdRevisionMedicamento { get; set; }
        //fk de la tabla revision y meicamento
        //public int IdRevision { get; set; }
        //public Revision Revision { get; set; }
        //public int IdMedicamento { get; set; }
       // public Medicamento Medicamento { get; set; }

        [Required]
        [StringLength(100)]
        public string DosisMedicada { get; set; }
    }
}
