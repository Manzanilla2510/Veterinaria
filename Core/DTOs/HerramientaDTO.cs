using System.ComponentModel.DataAnnotations;

namespace PVeterianaria.Core.DTOs
{
    public class HerramientaDTO
    {
        public string codigoHerramienta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
