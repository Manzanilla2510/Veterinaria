using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Core.Mapeadores;
using PVeterianaria.Infraestructura.Data;

namespace PVeterianaria.Infraestructura.Repositorio
{
    public class ProduccionLecheRepositorio :IProduccionRepositorio
    {
        private readonly PVeterianariaContext _context;
        public ProduccionLecheRepositorio(PVeterianariaContext context)
        {
            _context = context;
        }
        public async Task<List<ProduccionDTO>> GetProducciones()
        {
            var produccion = await _context.Producciones.ToListAsync();
            return produccion.Select(r => r.toProduccionDTO()).ToList();
        }
    }
}
