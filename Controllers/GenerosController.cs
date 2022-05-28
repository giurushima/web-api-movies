using GeneroInfo.API.Models;
using InformacionGeneros.API;
using Microsoft.AspNetCore.Mvc;

namespace GeneroInfo.API.Controllers
{
    [ApiController]
    [Route("api/peliculas")]
    public class GenerosController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<IEnumerable<GeneroDto>> GetGeneros()
        {
            return Ok(GenerosData.InstanciaActual.Generos);
        }

        [HttpGet("{id}")]
        public ActionResult<GeneroDto> GetGenero(int id)
        {
            var generoARetornar = GenerosData.InstanciaActual.Generos.FirstOrDefault(x => x.Id == id);
            if (generoARetornar == null)
                return NotFound();
            return Ok(generoARetornar);
        }
    }
}