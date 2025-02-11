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
            string? nome = null,
            string? localizacao = null,
            string? estado = null,
            string? referencia = null,
            string? descricao = null)
        {
            var query = _context.TodoItems.AsQueryable();


            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(p => p.nome_Loc.Contains(nome));
            }

            if (!string.IsNullOrEmpty(localizacao))
            {
                query = query.Where(p => p.desc_Loc.Contains(localizacao));
            }

            if (!string.IsNullOrEmpty(estado))
            {
                query = query.Where(p => p.est_Loc.Contains(estado));
            }

            if (!string.IsNullOrEmpty(referencia))
            {
                query = query.Where(p => p.ref_Loc.Contains(referencia));
            }


            if (!string.IsNullOrEmpty(descricao))
            {
                query = query.Where(p => p.descritivos_Loc.Contains(descricao));
            }


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
