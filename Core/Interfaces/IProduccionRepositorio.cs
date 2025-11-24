using PVeterianaria.Core.DTOs;

namespace PVeterianaria.Core.Interfaces
{
    public interface IProduccionRepositorio
    {
        public Task<List<ProduccionDTO>> GetProducciones();
    }
}
