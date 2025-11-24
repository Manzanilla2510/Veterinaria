using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Core.Mapeadores
{
    public static class VeterinarioMapeador
    {
        public static VeterinarioDTO toVeterinarioDTO(this Veterinario veterinario)
        {
            return new VeterinarioDTO()
            {
                Nombre = veterinario.Nombre,
                Apellido = veterinario.Apellido,
                Telefono = veterinario.Telefono,
                Ci = veterinario.Ci,
                Especialidad = veterinario.Especialidad,
                Correo = veterinario.Correo,
                Sueldo = veterinario.Sueldo
            };
        }
    }
}
