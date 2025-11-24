using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Core.Mapeadores
{
    public static class AlimentacionMapeador
    {
        public static AlimentacionDTO toAlimentacionDTO(this Alimentacion alimentacion)
        {
            return new AlimentacionDTO()
            {
                CodigoAnimal = alimentacion.CodigoAnimal,
                NombreAlimento = alimentacion.NombreAlimento,
                Tipo = alimentacion.Tipo,
                Descripcion = alimentacion.Descripcion,
                Fecha = alimentacion.Fecha,
                Cantidad = alimentacion.Cantidad,
                Estado = alimentacion.Estado,
            };
        }
    }
}
