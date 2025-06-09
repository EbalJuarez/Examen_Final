using System.ComponentModel.DataAnnotations;

namespace Examen_Final.Clases
{
    public class Vehiculo
    {
        [Required]
        public string? numero_chasis { get; set; }
        [Required]
        public string? Marca { get; set; }
        [Required]
        public string? año_fabricacion { get; set; }

    }
}
