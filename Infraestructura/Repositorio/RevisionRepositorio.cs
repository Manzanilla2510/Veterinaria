using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Core.Mapeadores;
using PVeterianaria.Infraestructura.Data;

namespace PVeterianaria.Infraestructura.Repositorio
{
    public class RevisionRepositorio: IRevisionRepositorio
    {
        private readonly PVeterianariaContext _context;
        public RevisionRepositorio(PVeterianariaContext _context)
        {
            this._context = _context;
        }
        public async Task<List<RevisionDTO>> GetRevisiones()
        {
            var revisiones = await _context.Revisiones.ToListAsync();
            return revisiones.Select(r => r.toRevisionDTO()).ToList();
        }

        public async Task<RevisionDTO> PostRevision(RevisionDTO dto)
        {
            Revision revision = new Revision
            {
                Fecha_Revision = dto.FechaRevision,
                Condicion = dto.Condicion,
                FechaRecuperacion = dto.FechaRecuperacion,
                Diagnostico = dto.Diagnostico,
                Temperatura = dto.Temperatura,
                PesoActual = dto.PesoActual,
                Tratamiento = dto.Tratamiento,
                Observaciones = dto.Observaciones
            };

            _context.Revisiones.Add(revision);
            await _context.SaveChangesAsync();

            return revision.toRevisionDTO();
        }
    }
}
