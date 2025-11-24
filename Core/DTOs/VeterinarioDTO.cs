namespace PVeterianaria.Core.DTOs
{
    public class VeterinarioDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Ci { get; set; }
        public string Especialidad { get; set; }
        public string Correo { get; set; }
        public decimal Sueldo { get; set; }
        
    }
    public class PutVeterinarioDTO
    {
        public string Ci { get; set; }
        public string Estado { get; set; }
    }
    public class DeleteVeterinarioDTO
    {
        public string Ci { get; set; }
       
    }
}
