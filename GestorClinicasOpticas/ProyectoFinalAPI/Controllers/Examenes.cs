using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamenesController : ControllerBase
    {
        private readonly OpticaContext _context;

        public ExamenesController(OpticaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Examen>>> GetExamenes()
        {
            return await _context.Examenes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Examen>> GetExamen(int id)
        {
            var examen = await _context.Examenes.FindAsync(id);

            if (examen == null)
            {
                return NotFound();
            }

            return examen;
        }

        [HttpPost]
        public async Task<ActionResult<Examen>> PostExamen(Examen examen)
        {
            if (!await _context.Pacientes.AnyAsync(p => p.Id == examen.PacienteId))
            {
                return BadRequest("El paciente especificado no existe.");
            }

            if (!await _context.Doctores.AnyAsync(d => d.Id == examen.DoctorId))
            {
                return BadRequest("El doctor especificado no existe.");
            }

            _context.Examenes.Add(examen);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExamen), new { id = examen.Id }, examen);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutExamen(int id, Examen examen)
        {
            if (id != examen.Id)
            {
                return BadRequest();
            }

            _context.Entry(examen).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExamen(int id)
        {
            var examen = await _context.Examenes.FindAsync(id);

            if (examen == null)
            {
                return NotFound();
            }

            _context.Examenes.Remove(examen);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
