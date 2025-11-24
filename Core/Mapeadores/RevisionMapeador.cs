using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Core.Mapeadores
{
    public static class RevisionMapeador
    {
        public static RevisionDTO toRevisionDTO(this Revision revision) {
            return new RevisionDTO()
            {
                FechaRevision = revision.Fecha_Revision,
                Condicion = revision.Condicion,
                FechaRecuperacion = revision.FechaRecuperacion,
                Diagnostico = revision.Diagnostico,
                Temperatura = revision.Temperatura,
                PesoActual = revision.PesoActual,
                Tratamiento = revision.Tratamiento,
                Observaciones = revision.Observaciones
            };
        }
    }
}
