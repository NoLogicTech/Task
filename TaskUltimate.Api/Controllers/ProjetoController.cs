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
    public class ProjetoController : ControllerBase
    {
        private CNGestaoProjetosContext _context;

        public ProjetoController(CNGestaoProjetosContext context)
        {
            _context = context;
        }
        // GET: api/<ProjetoController>
        [HttpGet]
        public List<Projeto> Get()
        {
            return _context.Projeto.ToList();
        }

        // GET api/<ProjetoController>/5
        [HttpGet("{id}")]
        public async Task<Projeto> Get(int id)
        {

            return await _context.Projeto.FindAsync(id);
        }

        // POST api/<ProjetoController>
        [HttpPost]
        public async Task Post([FromBody] Projeto value)
        {
            await _context.Projeto.AddAsync(value);
        }

        // PUT api/<ProjetoController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Projeto value)
        {
            if(await _context.Projeto.FindAsync(id) != null)
            {
                _context.Projeto.Update(value);
            }

        }

        // DELETE api/<ProjetoController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Projeto value = await _context.Projeto.FindAsync(id);
            _context.Projeto.Remove(value);
        }
    }
}
