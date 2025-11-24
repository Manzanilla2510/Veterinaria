using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVeterianaria.Core.DTOs
{
    public class AlimentacionDTO
    {
        public string CodigoAnimal { get; set; }
        public string NombreAlimento { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateOnly Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public string Estado { get; set; }
    }
    public class DeleteAlimentacionDTO
    {
        public string CodigoAnimal { get; set; }
        //public string NuevoCodigo { get; set; }
    }
}
