using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Core.Entidades;
using PVeterianaria.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.Mapeadores;

namespace PVeterinaria.Infraestructura.Repositorio
{
    public class VeterinarioRepositorio : IVeterinarioRepositorio
    {
        private readonly PVeterianariaContext _context;
        public VeterinarioRepositorio(PVeterianariaContext _context)
        {
            this._context = _context;
        }

        public async Task<VeterinarioDTO> DeleteVeterinario(DeleteVeterinarioDTO dto)
        {
            var veterinario = await _context.Veterinario
                .FirstOrDefaultAsync(a => a.Ci == dto.Ci);

            if (veterinario == null)
                return null;

            veterinario.Estado = "Deshabilitado";
            await _context.SaveChangesAsync();

            return veterinario.toVeterinarioDTO();
        }

        public async Task<List<VeterinarioDTO>> GetVeterinariosActivos()
        {
            return await (from v in _context.Veterinario
                          where v.Estado != "Deshabilitado"
                          select v).Select(us => us.toVeterinarioDTO()).ToListAsync();
        }

        public async Task<VeterinarioDTO> PostVeterinario(VeterinarioDTO dto)
        {
            Veterinario veterinario = new Veterinario
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Telefono = dto.Telefono,
                Ci = dto.Ci,
                Especialidad = dto.Especialidad,
                Correo = dto.Correo,
                Sueldo = dto.Sueldo,
                Estado = "Activo"
            };

            _context.Veterinario.Add(veterinario);
            await _context.SaveChangesAsync();

            return veterinario.toVeterinarioDTO();
        }

        public async Task<VeterinarioDTO> PutAnimal(string nombre, string apellido, string telefono, string ci, string especilaidad, string correo, decimal sueldo, string nuevoci)
        {
            var veterinario = await(from v in _context.Veterinario
                                    where v.Ci == ci
                                    select v).FirstOrDefaultAsync();
            
            veterinario.Nombre = nombre;
            veterinario.Apellido = apellido;
            veterinario.Telefono = telefono;
            veterinario.Ci = nuevoci;
            veterinario.Especialidad = especilaidad;
            veterinario.Correo = correo;
            veterinario.Sueldo = sueldo;
            await _context.SaveChangesAsync();
            return veterinario.toVeterinarioDTO();
        }

    }
}
