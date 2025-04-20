using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.DbContext;
using ApiLocadora;

namespace ApiLocadora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
            => Ok(ListaDb.Generos);

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var g = ListaDb.Generos.FirstOrDefault(x => x.Id == id);
            if (g == null) return NotFound();
            return Ok(g);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Genero genero)
        {
            genero.Id = ListaDb.Generos.Max(x => x.Id) + 1;
            ListaDb.Generos.Add(genero);
            return CreatedAtAction(nameof(GetById), new { id = genero.Id }, genero);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Genero genero)
        {
            var idx = ListaDb.Generos.FindIndex(x => x.Id == id);
            if (idx < 0) return NotFound();
            genero.Id = id;
            ListaDb.Generos[idx] = genero;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var g = ListaDb.Generos.FirstOrDefault(x => x.Id == id);
            if (g == null) return NotFound();
            ListaDb.Generos.Remove(g);
            return NoContent();
        }
    }
}
