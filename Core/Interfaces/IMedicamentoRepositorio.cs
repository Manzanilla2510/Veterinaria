using PVeterianaria.Core.DTOs;

namespace PVeterianaria.Core.Interfaces
{
    public interface IMedicamentoRepositorio
    {
        public Task<List<MedicamentoDTO>> GetMedicamentos();
    }
}
