using PVeterianaria.Core.DTOs;

namespace PVeterianaria.Core.Interfaces
{
    public interface IRevisionRepositorio
    {
        public Task<List<RevisionDTO>> GetRevisiones();
        public Task<RevisionDTO> PostRevision(RevisionDTO dto);
    }
}
