namespace PVeterianaria.Core.DTOs
{
    public class MedicamentoDTO
    {
        public string CodigoMedicamento { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaVencimiento { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
