using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Core.Mapeadores
{
    public static class HerramientaMapeador
    {
        public static HerramientaDTO toHerramientaDTO(this Herramienta herramienta)
        {
            return new HerramientaDTO()
            {
                codigoHerramienta = herramienta.codigoHerramienta,
                Nombre = herramienta.Nombre,
                Descripcion = herramienta.Descripcion,
                Estado = herramienta.Estado,
            };
        }
    }
}
