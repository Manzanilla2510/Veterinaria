using System.ComponentModel.DataAnnotations;

namespace PVeterianaria.Core.Entidades
{
    public class RevisionHerramienta
    {
        [Key]
        public int IdRevisionHeramienta { get; set; }
        //fk de las tablas revision y heramieta
        //public int IdRevision { get; set; }
        //public Revision Revision { get; set; }
        //public int IdHerramienta { get; set; }
        //public Herramienta Heramienta { get; set; }

        [Required]
        [StringLength(50)]
        public string Utilidad { get; set; }
    }
}
