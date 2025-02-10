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

        // GET: api/PontosTuristicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetPontosTuristicos()
        {
            return await _context.TodoItems.ToListAsync();  // Retorna todos os pontos turísticos
        }

        // GET: api/PontosTuristicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetPontoTuristico(int id)
        {
            var pontoTuristico = await _context.TodoItems.FindAsync(id);  // Busca um ponto turístico pelo id

            if (pontoTuristico == null)
            {
                return NotFound();  // Retorna 404 caso não encontre o ponto turístico
            }

            return pontoTuristico;
        }

        // PUT: api/PontosTuristicos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPontoTuristico(int id, TodoItem pontoTuristico)
        {
            if (id != pontoTuristico.Id)
            {
                return BadRequest();  // Retorna erro se o id não corresponder
            }

            _context.Entry(pontoTuristico).State = EntityState.Modified;  // Marca o ponto turístico como modificado

            try
            {
                await _context.SaveChangesAsync();  // Salva as mudanças no banco de dados
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();  // Se o ponto turístico não existir, retorna erro 404
                }
                else
                {
                    throw;
                }
            }

            return NoContent();  // Retorna código 204 caso a atualização tenha sido bem-sucedida
        }

        // POST: api/PontosTuristicos
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostPontoTuristico(TodoItem pontoTuristico)
        {
            _context.TodoItems.Add(pontoTuristico);  // Adiciona um novo ponto turístico
            await _context.SaveChangesAsync();  // Salva no banco de dados

            return CreatedAtAction(nameof(GetPontoTuristico), new { id = pontoTuristico.Id }, pontoTuristico);  // Retorna o ponto turístico criado
        }

        // DELETE: api/PontosTuristicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePontoTuristico(int id)
        {
            var pontoTuristico = await _context.TodoItems.FindAsync(id);  // Busca o ponto turístico pelo id
            if (pontoTuristico == null)
            {
                return NotFound();  // Se não encontrar o ponto turístico, retorna erro 404
            }

            _context.TodoItems.Remove(pontoTuristico);  // Remove o ponto turístico
            await _context.SaveChangesAsync();  // Salva as mudanças no banco de dados

            return NoContent();  // Retorna código 204 caso a exclusão tenha sido bem-sucedida
        }

        // Método auxiliar para verificar se o ponto turístico existe no banco de dados
        private bool TodoItemExists(int id)
        {
            return _context.TodoItems.Any(e => e.Id == id);  // Retorna true se o ponto turístico existir
        }
    }
}
