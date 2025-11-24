using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Core.Mapeadores
{
    public static class ProduccionLecheMapeador
    {
        public static ProduccionDTO toProduccionDTO(this ProduccionLeche produccion) {
            return new ProduccionDTO
            {
                fechaProduccion = produccion.Fecha_produccion,
                CantidadLeche = produccion.Cantidad_Leche
            };
        }
    }
}
