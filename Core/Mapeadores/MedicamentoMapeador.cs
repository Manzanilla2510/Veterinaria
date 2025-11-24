using Microsoft.CodeAnalysis.CSharp.Syntax;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Core.Mapeadores
{
    public static class MedicamentoMapeador
    {
        public static MedicamentoDTO toMedicamentoDTO(this Medicamento medicamento) {
            return new MedicamentoDTO() {
                CodigoMedicamento = medicamento.CodigoMedicamento,
                Nombre = medicamento.Nombre,
                FechaVencimiento = medicamento.FechaVencimiento,
                Cantidad = medicamento.Cantidad,
                Descripcion = medicamento.Descripcion,
            };
        }

    }
}
