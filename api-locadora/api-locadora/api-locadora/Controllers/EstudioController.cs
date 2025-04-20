using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.DbContext;
using ApiLocadora;

namespace ApiLocadora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudioController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
            => Ok(ListaDb.Estudios);

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var e = ListaDb.Estudios.FirstOrDefault(x => x.Id == id);
            if (e == null) return NotFound();
            return Ok(e);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Estudio estudio)
        {
            estudio.Id = ListaDb.Estudios.Max(x => x.Id) + 1;
            ListaDb.Estudios.Add(estudio);
            return CreatedAtAction(nameof(GetById), new { id = estudio.Id }, estudio);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Estudio estudio)
        {
            var idx = ListaDb.Estudios.FindIndex(x => x.Id == id);
            if (idx < 0) return NotFound();
            estudio.Id = id;
            ListaDb.Estudios[idx] = estudio;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var e = ListaDb.Estudios.FirstOrDefault(x => x.Id == id);
            if (e == null) return NotFound();
            ListaDb.Estudios.Remove(e);
            return NoContent();
        }
    }
}
