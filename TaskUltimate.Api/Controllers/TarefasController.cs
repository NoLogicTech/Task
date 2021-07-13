using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskUltimateBibliotec.Models;
using Microsoft.AspNetCore.Http;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskUltimate.Api.Controllers
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
        public async Task<ActionResult<List<Tarefa>>> Get()
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
        public async Task<List<Tarefa>> GetbyProject(int id)
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

        [HttpGet("filho/{id}")]
        public List<Tarefa> GetFilho(int id)
        {
            List<Tarefa> herdeiros = new List<Tarefa>();
            if(_context.Tarefa.Find(id) != null)
            {
                foreach(Tarefa elemento in _context.Tarefa.ToList())
                {
                    if(elemento.TarefaParentid == id)
                        herdeiros.Add(elemento);
                }
            }
            return herdeiros;
        }
        [HttpGet("parentbyproject/{id}")]
        public async Task<List<Tarefa>> GetParentByProject(int id)
        {
            List<Tarefa> elementos = await GetbyProject(id);
            List<Tarefa> parentes = new List<Tarefa>();
            foreach(Tarefa elemento in elementos)
            {
                if (elemento.TarefaParentid == 0 | elemento.TarefaParentid == null)
                    parentes.Add(elemento);
            }
            return parentes;
        }

        // POST api/<TarefasController>
        [HttpPost]
        public async Task Post([FromBody] Tarefa value)
        {
            _context.Tarefa.Add(value);
            await _context.SaveChangesAsync();

            int posicao = value.TarefaPosicao ?? 0;
            value.TarefaPosicao = 0;
            await Insert(value.TarefaId, posicao, value);
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
        [HttpPut("{id}/{posicao}")]
        public async Task Insert(int id, int posicao, [FromBody] Tarefa value)
        {
            List<Tarefa> tarefas;
            int? ultimaposicao = value.TarefaPosicao;
            value.TarefaPosicao = posicao;
            await Put(value.TarefaId, value);

            if (id == value.TarefaId)
            {
                tarefas = _context.Tarefa.ToList();
                
                tarefas.Insert(posicao - 1, value);
                foreach (Tarefa elemento in tarefas)
                {
                    if (elemento.TarefaPosicao >= posicao & elemento.TarefaPosicao <= ultimaposicao & elemento.TarefaId != value.TarefaId)
                    {
                        if (posicao - ultimaposicao > 0)
                            elemento.TarefaPosicao -= 1;
                        else if(posicao - ultimaposicao <= 0)
                            elemento.TarefaPosicao += 1;
                        await Put(elemento.TarefaId, elemento);
                    }
                }
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
