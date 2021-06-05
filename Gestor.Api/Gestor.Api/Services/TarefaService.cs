using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestor.Api.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;
using Gestor.Api.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestor.Api.Services
{
 
    public class TarefasService
    {

        private CNGestaoProjetosContext _context;

        public TarefasService(CNGestaoProjetosContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        
        public string Get()
        {
            JsonConversao jsonconv = new JsonConversao();
            List<Tarefa> tarefa = new List<Tarefa>();
            tarefa = _context.Tarefa.ToList();
            
            return jsonconv.ConverteObjectParaJSon(tarefa);
        }

        // GET api/<ValuesController>/5
  
        public string Get(int id)
        {
            JsonConversao jsonconv = new JsonConversao();
            List<Tarefa> tarefa = new List<Tarefa>();
            tarefa = _context.Tarefa.ToList();
            foreach(Tarefa trf in tarefa)
            {
                if(trf.TarefaId == id)
                {
                    return jsonconv.ConverteObjectParaJSon(trf);
                }
            }
            return "{}";
        }

        // POST api/<ValuesController>
        
        public void Post([FromBody] string value)
        {
            JsonConversao jsonconv = new JsonConversao();
            
            Tarefa trf = new Tarefa();

            _context.Tarefa.Add(trf);
        }

        // PUT api/<ValuesController>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        public void Delete(int id)
        {
        }
    }
}
