using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Core.Mapeadores;
using PVeterianaria.Infraestructura.Data;

namespace PVeterianaria.Infraestructura.Repositorio
{
    public class HerramientaRepositorio:IHerramientaRepositorio
    {
        private readonly PVeterianariaContext _context;
        public HerramientaRepositorio(PVeterianariaContext context)
        {
            this._context = context;
        }

        public async Task<List<HerramientaDTO>> GetHerramienta()
        {
            return await(from v in _context.Herramientas
                         where v.Estado != "Deshabilitado"
                         select v).Select(us => us.toHerramientaDTO()).ToListAsync();
        }
    }
}
