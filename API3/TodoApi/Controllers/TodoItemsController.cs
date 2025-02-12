using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontosTuristicosController : ControllerBase
    {
        private readonly TodoContext _context;

        public PontosTuristicosController(TodoContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetPontosTuristicos(
    string? searchTerm = null)
        {
            var query = _context.TodoItems.AsQueryable();

            // Se um termo de pesquisa foi fornecido, aplica o filtro em nome, estado e descrição
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p =>
                    p.nome_Loc.Contains(searchTerm) ||
                    p.est_Loc.Contains(searchTerm) ||
                    p.desc_Loc.Contains(searchTerm) ||
                    p.descritivos_Loc.Contains(searchTerm)); 

            }

            // Executa a consulta e retorna os resultados
            var pontosTuristicos = await query.ToListAsync();

            return pontosTuristicos;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetPontoTuristico(int id)
        {
            var pontoTuristico = await _context.TodoItems.FindAsync(id);

            if (pontoTuristico == null)
            {
                return NotFound();
            }

            return pontoTuristico;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutPontoTuristico(int id, TodoItem pontoTuristico)
        {
            if (id != pontoTuristico.Id)
            {
                return BadRequest();
            }

            _context.Entry(pontoTuristico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostPontoTuristico(TodoItem pontoTuristico)
        {
            _context.TodoItems.Add(pontoTuristico);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPontoTuristico), new { id = pontoTuristico.Id }, pontoTuristico);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePontoTuristico(int id)
        {
            var pontoTuristico = await _context.TodoItems.FindAsync(id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(pontoTuristico);
            await _context.SaveChangesAsync();
            return NoContent();
        }


        private bool TodoItemExists(int id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
