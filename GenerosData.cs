using GeneroInfo.API.Models;

namespace InformacionGeneros.API
{
    public class GenerosData
    {
        public List<GeneroDto> Generos { get; set; }

        public static GenerosData InstanciaActual { get; } = new GenerosData();

        public GenerosData()
        {
                Generos = new List<GeneroDto>()
            {
                new GeneroDto()
                {
                     Id = 1,
                     Nombre = "Terror",
                     Descripcion = "Peliculas de terror.",
                     Peliculas = new List<PeliculasDto>()
                     {
                         new PeliculasDto() {
                             Id = 1,
                             Nombre = "Annabelle",
                             Descripcion = "asdasdasdasd" },
                          new PeliculasDto() {
                             Id = 2,
                             Nombre = "El juego del miedo 4",
                             Descripcion = "qwerqwe" },
                     }
                },
                new GeneroDto()
                {
                    Id = 2,
                    Nombre = "Comedia",
                    Descripcion = "Peliculas de comedia.",
                    Peliculas = new List<PeliculasDto>()
                     {
                         new PeliculasDto() {
                             Id = 3,
                             Nombre = "Scary Movie",
                             Descripcion = "asojfaofa" },
                          new PeliculasDto() {
                             Id = 4,
                             Nombre = "TED",
                             Descripcion = "gklasklfka" },
                     }
                },
                new GeneroDto()
                {
                    Id= 3,
                    Nombre = "Accion",
                    Descripcion = "Peliculas de accion.",
                    Peliculas = new List<PeliculasDto>()
                     {
                         new PeliculasDto() {
                             Id = 5,
                             Nombre = "Duro de matar",
                             Descripcion = "AFASFASFA" },
                          new PeliculasDto() {
                             Id = 6,
                             Nombre = "Ironman",
                             Descripcion = "Tsdgsdgsd" },
                     }
                }
            };
        }
    }
}