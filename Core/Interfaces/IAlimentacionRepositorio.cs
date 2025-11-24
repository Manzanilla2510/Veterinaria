using PVeterianaria.Core.DTOs;

namespace PVeterianaria.Core.Interfaces
{
    public interface IAlimentacionRepositorio
    {
        public Task<List<AlimentacionDTO>> GetLista();
        public Task<AlimentacionDTO> PostAlimentacion(AlimentacionDTO dto);
        public Task<AlimentacionDTO> DeleteAlimentacion(DeleteAlimentacionDTO dto);
    }
}
