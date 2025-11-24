using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Core.Mapeadores;
using PVeterianaria.Infraestructura.Data;

namespace PVeterianaria.Infraestructura.Repositorio
{
    public class AnimalRepositorio : IAnimalRepositorio
    {
        private readonly PVeterianariaContext _context;
        public AnimalRepositorio(PVeterianariaContext context)
        {
            _context = context;
        }

        public async Task<AnimalDTO> PutAnimal(PutAnimalDTO dto)
        {
            var animal = await _context.Animal
        .FirstOrDefaultAsync(a => a.CodigoAnimal == dto.CodigoAnimal);

            if (animal == null)
                return null;

            animal.Estado = dto.Estado;
            await _context.SaveChangesAsync();

            return animal.toAnimalDTO();
        }
        public async Task<List<AnimalDTO>> GetAnimalesEnTratamientos()
        {
            return await(from a in _context.Animal
                         where a.Estado == "tratamiento"
                         select a).Select(a => a.toAnimalDTO()).ToListAsync();
        }
    }
}
