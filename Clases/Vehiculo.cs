using System.ComponentModel.DataAnnotations;

namespace Examen_Final.Clases
{
    public class Vehiculo
    {
        [Required]
        public string? numero_chasis { get; set; }
        [Required]
        [StringLength(10,
        ErrorMessage = "Contien muchos caracteres para una marca")]
        public string? Marca { get; set; }
        [Required]
        [StringLength(4, ErrorMessage = "El año debe tener exactamente 4 caracteres.")]
        [MinLength(4, ErrorMessage = "El año debe tener exactamente 4 caracteres.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "El DPI debe contener solo números.")]
        public string? año_fabricacion { get; set; }

        public int con { get; set; }
    }
}
