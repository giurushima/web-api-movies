namespace GeneroInfo.API.Models
{
    public class GeneroDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }

        public ICollection<PeliculasDto> Peliculas { get; set; } = new List<PeliculasDto>(); 
        public int CantidadPeliculas
        {
            get { return Peliculas.Count; }
        }
    }
}