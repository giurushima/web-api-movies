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
                     Descripcion = "Peliculas de terror",
                     Peliculas = new List<PeliculasDto>()
                     {
                         new PeliculasDto() {
                             Id = 1,
                             Nombre = "Annabelle",
                             Descripcion = "Annabelle es una película estadounidense de terror dirigida por John R. Leonetti y escrita por Gary Dauberman. " +
                             "Se trata de un spin-off de la película The Conjuring, siendo además la segunda entrega de The Conjuring Universe. " +
                             "Protagonizada por Annabelle Wallis y Ward Horton, se estrenó el 3 de octubre de 2014 en Estados Unidos." },
                          new PeliculasDto() {
                             Id = 2,
                             Nombre = "El juego del miedo 4",
                             Descripcion = "Saw IV (conocida como El juego del miedo IV en Hispanoamérica) es la cuarta película de la saga Saw. " +
                             "En esta película continúa la historia de Jigsaw, un asesino y su obsesión por enseñarle a la gente el valor de sus vidas. " +
                             "Después de que Jigsaw muriera en la película anterior (Saw III), " +
                             "la película se enfoca en su habilidad de manipular a la gente para que continúen su trabajo." },
                     }
                },
                new GeneroDto()
                {
                    Id = 2,
                    Nombre = "Comedia",
                    Descripcion = "Peliculas de comedia",
                    Peliculas = new List<PeliculasDto>()
                     {
                         new PeliculasDto() {
                             Id = 3,
                             Nombre = "Scary Movie",
                             Descripcion = "Scary Movie (titulada Scary Movie: Una película de miedo en Hispanoamérica) es una película estadounidense de humor negro del año 2000," +
                             " dirigida por Keenen Ivory Wayans y escrita por sus hermanos Shawn Wayans y Marlon Wayans, quienes también actúan en la película." +
                             " Las bromas de mal gusto, su lenguaje soez y escenas escatológicas han sido las claves de su éxito en Estados Unidos." },
                          new PeliculasDto() {
                             Id = 4,
                             Nombre = "TED",
                             Descripcion = "Ted es una película estadounidense de comedia dirigida por Seth MacFarlane y protagonizada por Mark Wahlberg, Mila Kunis y MacFarlane." +
                             " El rodaje comenzó en mayo de 2011 en Boston y Swampscott, Massachusetts." },
                     }
                },
                new GeneroDto()
                {
                    Id= 3,
                    Nombre = "Accion",
                    Descripcion = "Peliculas de accion",
                    Peliculas = new List<PeliculasDto>()
                     {
                         new PeliculasDto() {
                             Id = 5,
                             Nombre = "Duro de matar",
                             Descripcion = "Die Hard (titulada Duro de matar en Hispanoamérica y Jungla de cristal en España) es una película de acción estadounidense de 1988 dirigida por John McTiernan y escrita por Steve de Souza y Jeb Stuart. " +
                             "Está basada en la novela Nothing Lasts Forever (1979) de Roderick Thorp." },
                          new PeliculasDto() {
                             Id = 6,
                             Nombre = "Ironman",
                             Descripcion = "Iron Man (titulada Iron Man: el hombre de hierro en Hispanoamérica) es una película de superhéroes. Es la primera entrega del Universo cinematográfico de Marvel. " +
                             "La cinta fue dirigida por Jon Favreau, con un guion de Stan Lee, Hawk Ostby, Art Marcum y Matt Holloway." },
                     }
                }
            };
        }
    }
}