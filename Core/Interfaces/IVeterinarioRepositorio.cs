using PVeterianaria.Core.DTOs;

namespace PVeterianaria.Core.Interfaces
{
    public interface IVeterinarioRepositorio
    {
        public Task<List<VeterinarioDTO>> GetVeterinariosActivos();
        public Task<VeterinarioDTO> PostVeterinario(VeterinarioDTO dto);
        public Task<VeterinarioDTO> PutAnimal(string nombre, string apellido, string telefono, string ci, string especilaidad, string correo, decimal sueldo, string nuevoci);
        public Task<VeterinarioDTO> DeleteVeterinario(DeleteVeterinarioDTO dto);
    }
}
