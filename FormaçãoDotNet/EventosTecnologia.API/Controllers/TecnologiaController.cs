using EventosTecnologia.API.Entities;
using EventosTecnologia.API.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventosTecnologia.API.Controllers
{
    [Route("api/eventos-tecnologia")]
    [ApiController]
    public class TecnologiaController : ControllerBase
    {
        private readonly EveTecnologiaDbContext _context;

        public TecnologiaController(EveTecnologiaDbContext context)
        {
            _context = context;
        }

        //api/eve-tecnologia/1231231 GET ALL - TODOS OS EVENTOS
        [HttpGet]
        public IActionResult GetAll() 
        {
            var eveTecnologia = _context.EveTecnologia.Where(d => !d.EstaDeletado).ToList();
            return Ok(eveTecnologia);
        }

        //api/eve-tecnologia/1231234 GET
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var eveTecnologia = _context.EveTecnologia.SingleOrDefault(d => d.Id == id);
            if(eveTecnologia == null)
            {
                return NotFound();
            }

            return Ok(eveTecnologia);
        }

        //api/eve-tecnologia/1231234 POST
        [HttpPost]
        public IActionResult Post(EveTecnologia eveTecnologia)
        {
            _context.EveTecnologia.Add(eveTecnologia);
            return CreatedAtAction(nameof(GetById), new { id = eveTecnologia.Id }, eveTecnologia);

        }

        //api/eve-tecnologia/1231234 POST
        [HttpPost("{id}/palestrante")]
        public IActionResult PostPalestrante(Guid id, EveTecPalestrante palestrante)
        {
            var eveTecnologia = _context.EveTecnologia.SingleOrDefault(d => d.Id == id);

            if(eveTecnologia == null) 
            {
                return NotFound();
            }

            eveTecnologia.Palestrante.Add(palestrante);
            return NoContent();
        }

        //api/eve-tecnologia/1231231 PUT
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, EveTecnologia input)
        {
            var eveTecnologia = _context.EveTecnologia.SingleOrDefault(d => d.Id == id);
            if(eveTecnologia == null) 
            {
                return NotFound();
            }

            eveTecnologia.Update(input.Titulo, input.Descricao, input.DataInicio, input.DataTermino);

            return NoContent();

        }

        //api/eve-tecnologia/1231234 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) 
        {
            var eveTecnologia = _context.EveTecnologia.SingleOrDefault(d => d.Id == id);

            if(eveTecnologia == null)
            {
                return NotFound();
            }

            eveTecnologia.Delete();

            return NoContent();
        }
    }
}
