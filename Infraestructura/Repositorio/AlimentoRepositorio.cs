using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Infraestructura.Data;
using PVeterianaria.Core.Mapeadores;
using Microsoft.EntityFrameworkCore;

namespace PVeterianaria.Infraestructura.Repositorio
{
    public class AlimentoRepositorio : IAlimentacionRepositorio
    {
        private readonly PVeterianariaContext _context;
        public AlimentoRepositorio(PVeterianariaContext context)
        {
            this._context = context;
        }

        public async Task<AlimentacionDTO> DeleteAlimentacion(DeleteAlimentacionDTO dto)
        {
            var alimentacion = await _context.Alimentacion
        .FirstOrDefaultAsync(a => a.CodigoAnimal == dto.CodigoAnimal);

            if (alimentacion == null)
                return null; 

            alimentacion.Estado = "Deshabilitado";
            await _context.SaveChangesAsync();

            return alimentacion.toAlimentacionDTO();
        }

        public async Task<List<AlimentacionDTO>> GetLista()
        {
            return await (from v in _context.Alimentacion
                          where v.Estado != "Deshabilitado"
                          select v).Select(us => us.toAlimentacionDTO()).ToListAsync();
        }

        public async Task<AlimentacionDTO> PostAlimentacion(AlimentacionDTO dto)
        {
            Alimentacion alimentacion = new Alimentacion
            {
                CodigoAnimal = dto.CodigoAnimal,
                NombreAlimento = dto.NombreAlimento,
                Tipo = dto.Tipo,
                Descripcion = dto.Descripcion,
                Fecha = dto.Fecha,
                Cantidad = dto.Cantidad,
                Estado = dto.Estado
            };

            _context.Alimentacion.Add(alimentacion);
            await _context.SaveChangesAsync();

            return alimentacion.toAlimentacionDTO();
        }
    }
}
