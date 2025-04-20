using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.DbContext;
using ApiLocadora.Dto;

namespace ApiLocadora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
            => Ok(ListaDb.Filmes);

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var f = ListaDb.Filmes.FirstOrDefault(x => x.Id == id);
            if (f == null) return NotFound();
            return Ok(f);
        }

        [HttpPost]
        public ActionResult Create([FromBody] FilmeDto dto)
        {
            dto.Id = ListaDb.Filmes.Max(x => x.Id) + 1;
            ListaDb.Filmes.Add(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] FilmeDto dto)
        {
            var idx = ListaDb.Filmes.FindIndex(x => x.Id == id);
            if (idx < 0) return NotFound();
            dto.Id = id;
            ListaDb.Filmes[idx] = dto;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var f = ListaDb.Filmes.FirstOrDefault(x => x.Id == id);
            if (f == null) return NotFound();
            ListaDb.Filmes.Remove(f);
            return NoContent();
        }
    }
}
