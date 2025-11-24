namespace PVeterianaria.Core.DTOs
{
    public class RevisionDTO
    {
        public DateOnly FechaRevision { get; set; }
        public string Condicion { get; set; }
        public DateOnly FechaRecuperacion { get; set; }
        public string Diagnostico { get; set; }
        public decimal Temperatura { get; set; }
        public decimal PesoActual { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
    }
}
