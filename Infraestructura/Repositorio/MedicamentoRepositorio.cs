using PVeterianaria.Core.Interfaces;
using PVeterianaria.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Mapeadores;

namespace PVeterianaria.Infraestructura.Repositorio
{
    public class MedicamentoRepositorio : IMedicamentoRepositorio
    {
        private readonly PVeterianariaContext _context;
        public MedicamentoRepositorio(PVeterianariaContext context)
        {
            _context = context;
        }

        public async Task<List<MedicamentoDTO>> GetMedicamentos()
        {
            var medicamentos = await _context.Medicamentos.ToListAsync();
            return medicamentos.Select(r => r.toMedicamentoDTO()).ToList();
        }
    }

}
