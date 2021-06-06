using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestor.Api.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;
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
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<List<Tarefa>> Get()
        {
            List<Tarefa> tarefa = new List<Tarefa>();
            tarefa = _context.Tarefa.ToList();
            return tarefa;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Tarefa> Get(int id)
        {
            List<Tarefa> tarefa = new List<Tarefa>();
            tarefa = _context.Tarefa.ToList();
            foreach(Tarefa trf in tarefa)
            {
                if(trf.TarefaId == id)
                {
                    return trf;
                }
            }
            return NotFound();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Adicionar([FromBody] Tarefa trf)
        {
            _context.Tarefa.Add(trf);
            _context.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void AtualizarTarefa([FromBody] Tarefa trf)
        {
            _context.Tarefa.Update(trf);
            _context.SaveChanges();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            List<Tarefa> tarefa = new List<Tarefa>();
            tarefa = _context.Tarefa.ToList();
            foreach (Tarefa trf in tarefa)
            {
                if (trf.TarefaId == id)
                {
                    _context.Remove(trf);
                    _context.SaveChanges();
                }
            }
        }
    }
}
