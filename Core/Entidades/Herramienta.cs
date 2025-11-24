using System.ComponentModel.DataAnnotations;

namespace PVeterianaria.Core.Entidades
{
    public class Herramienta
    {
        [Key]
        public int IdHerramienta { get; set; }

        //FK de la tabla tipoherramietna
        //public int IdTipoHerramienta { get; set; }
        //public TipoHerramienta TipoHerramienta { get; set; }

        [Required]
        [StringLength(25)]
        public string codigoHerramienta { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(25)]
        public string Estado { get; set; }
    }
}
