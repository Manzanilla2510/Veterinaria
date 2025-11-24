using PVeterianaria.Core.Interfaces;

namespace PVeterianaria.Core.DTOs
{
    public class AnimalDTO 
    {
        public string CodigoAnimal { get; set; }
        //public string NuevoCodigoAnimal { get; set; }
        public decimal Peso { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string Estado { get; set; }
    }
    public class PutAnimalDTO
    {
        public string CodigoAnimal { get; set; }
        public string Estado { get; set; }

    }
}
