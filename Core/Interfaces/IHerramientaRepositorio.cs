using PVeterianaria.Core.DTOs;

namespace PVeterianaria.Core.Interfaces
{
    public interface IHerramientaRepositorio
    {
        public Task<List<HerramientaDTO>> GetHerramienta();
       
    }
}
