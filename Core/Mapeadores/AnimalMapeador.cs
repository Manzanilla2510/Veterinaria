using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Core.Mapeadores
{
    public static class AnimalMapeador
    {
        public static AnimalDTO toAnimalDTO(this Animal animal) {
            return new AnimalDTO()
            {
                CodigoAnimal = animal.CodigoAnimal, 
                Peso =animal.Peso,
                Edad=animal.Edad,
                Raza=animal.Raza,
                FechaIngreso=animal.Fecha_Ingreso,
                Estado=animal.Estado
            };
        }
    }
}
