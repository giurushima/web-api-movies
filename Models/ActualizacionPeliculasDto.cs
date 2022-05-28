using System.ComponentModel.DataAnnotations;

namespace GeneroInfo.API.Controllers
{
    public class ActualizacionPeliculasDto
    {
        [Required(ErrorMessage = "Agregá un nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [MaxLength(500)]
        public string? Descripcion { get; set; }
    }
}