using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskUltimate.Models;
using Microsoft.AspNetCore.Http;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestor.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private CNGestaoProjetosContext _context;

        public TarefasController(CNGestaoProjetosContext context)
        {
            _context = context;
        }

        // GET: api/<TarefasController>
        [HttpGet]
        public ActionResult<List<Tarefa>> Get()
        {
            return _context.Tarefa.ToList();
        }

        // GET api/<TarefasController>/5
        [HttpGet("{id}")]
        public async Task<Tarefa> Get(int id)
        {
            return await _context.Tarefa.FindAsync(id);
        }

        // GET api/<TarefasController>/5
        [HttpGet("projeto/{id}")]
        public List<Tarefa> GetbyProject(int id)
        {
            List<Tarefa> temp = _context.Tarefa.ToList();
            List<Tarefa> projeto =  new List<Tarefa>();

           // Ele percorre a lista de tarefas para
           foreach (Tarefa trf2 in temp)
           {
            // encontrar uma tarefa esteja no mesmo projeto que o contador
                if (id == trf2.ProjetoId)
                {       // entao ele adiciona a tarefa ao projeto
                        projeto.Add(trf2 );
                }
           }

            return projeto;
        }

        // POST api/<TarefasController>
        [HttpPost]
        public async Task Post([FromBody] Tarefa value)
        {
            await _context.Tarefa.AddAsync(value);
            await _context.SaveChangesAsync();
        }

        // PUT api/<TarefasController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Tarefa value)
        {
            if(id == value.TarefaId)
            {
                _context.Tarefa.Update(value);
                await _context.SaveChangesAsync();
            }
        }

        // DELETE api/<TarefasController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Tarefa value =  _context.Tarefa.Find(id);
            if(value != null)
                _context.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
