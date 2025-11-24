using PVeterianaria.Core.DTOs;

namespace PVeterianaria.Core.Interfaces
{
    public interface IAnimalRepositorio
    {
        public Task<AnimalDTO> PutAnimal(PutAnimalDTO dto);
        public Task<List<AnimalDTO>> GetAnimalesEnTratamientos();
    }
}
