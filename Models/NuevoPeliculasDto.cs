using System.ComponentModel.DataAnnotations;

namespace GeneroInfo.API.Controllers
{
    public class NuevoPeliculasDto
    {
        [Required(ErrorMessage = "Agregá un nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [MaxLength(200)]
        public string? Descripcion { get; set; }
    }
}