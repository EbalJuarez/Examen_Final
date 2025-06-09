using System.ComponentModel.DataAnnotations;

namespace Examen_Final.Clases
{
    public class Automovil : Vehiculo
    {
        [Required]
        public int numero_puertas {  get; set; }
        [Required]
        public string? tipo_combustible { get; set; }

    }
}
