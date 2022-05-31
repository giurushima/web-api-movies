using GeneroInfo.API.Models;
using InformacionGeneros.API;
using Microsoft.AspNetCore.Mvc;

namespace GeneroInfo.API.Controllers
{
    [ApiController]
    [Route("api/generos/{idGenero}/peliculas")]
    public class PeliculasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PeliculasDto>> GetPeliculas(int idGenero)
        {
            var genero = GenerosData.InstanciaActual.Generos.FirstOrDefault(x => x.Id == idGenero);
            if (genero == null)
                return NotFound();

            return Ok(genero.Peliculas);
        }

        [HttpGet("{idPeliculas}", Name = "GetPeliculas")] 
        public ActionResult<PeliculasDto> GetPeliculas(int idGenero, int idPeliculas)
        {
            var gender = GenerosData.InstanciaActual.Generos.FirstOrDefault(x => x.Id == idGenero);

            if (gender == null)
                return NotFound();

            var movies = gender.Peliculas.FirstOrDefault(x => x.Id == idPeliculas);

            if (movies == null)
                return NotFound();

            return Ok(movies);
        }

        [HttpPost]
        public ActionResult<PeliculasDto> CrearPeliculas(int idGenero, NuevoPeliculasDto peliculas)
        {
            var genero = GenerosData.InstanciaActual.Generos.FirstOrDefault(c => c.Id == idGenero);
            if (genero is null)
            {
                return NotFound();
            }

            var idMaximoPeliculas = GenerosData.InstanciaActual.Generos.SelectMany(c => c.Peliculas).Max(p => p.Id);

            var nuevoPeliculas = new PeliculasDto      
            {
                Id = ++idMaximoPeliculas,
                Nombre = peliculas.Nombre,
                Descripcion = peliculas.Descripcion
            };

            genero.Peliculas.Add(nuevoPeliculas);

            return CreatedAtRoute(
                "GetPeliculas", 
                new 
                {
                    idGenero,
                    idPeliculas = nuevoPeliculas.Id
                },
                nuevoPeliculas); 
        }

        [HttpPut("{idPeliculas}")]
        public ActionResult ActualizarPeliculas(int idGenero, int idPeliculas, ActualizacionPeliculasDto movies)
        {
            var genero = GenerosData.InstanciaActual.Generos.FirstOrDefault(c => c.Id == idGenero);

            if (genero == null)
                return NotFound();

            var peliculasBase = genero.Peliculas.FirstOrDefault(p => p.Id == idPeliculas);
            if (peliculasBase == null)
                return NotFound();

            peliculasBase.Nombre = movies.Nombre;
            peliculasBase.Descripcion = movies.Descripcion;

            return NoContent();
        }


        [HttpDelete("{idPeliculas}")]
        public ActionResult DeleteMovies(int idGenero, int idPeliculas)
        {
            var genero = GenerosData.InstanciaActual.Generos.FirstOrDefault(c => c.Id == idGenero);
            if (genero is null)
                return NotFound();

            var peliculasAEliminar = genero.Peliculas
                .FirstOrDefault(p => p.Id == idPeliculas);
            if (peliculasAEliminar is null)
                return NotFound();

            genero.Peliculas.Remove(peliculasAEliminar);

            return NoContent();
        }
    }
}