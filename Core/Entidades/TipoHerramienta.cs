using System.ComponentModel.DataAnnotations;

namespace PVeterianaria.Core.Entidades
{
    public class TipoHerramienta
    {
        [Key]
        public int IdTipoHerramienta { get; set; }
        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }
        //relacion con la tabla herramienta
        //public ICollection<Herramienta> Heramienta { get; set; } = new List<Herramienta>();
    }
}
