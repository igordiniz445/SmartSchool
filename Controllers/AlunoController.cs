using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartSchool.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly SmartContext _context;
        public AlunoController(SmartContext context){
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefaultAsync(a => a.Id.Equals(id));
            if(aluno == null){return BadRequest("Aluno não encontrado");}
            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome)
        {
            var aluno = _context.Alunos.FirstOrDefaultAsync(a => a.Nome.Equals(nome));
            if(aluno == null){return BadRequest("Aluno não encontrado");}
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _context.Add(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _context.Alunos.AsNoTracking().FirstOrDefaultAsync(a => a.Id.Equals(id));
            if(aluno==null)
                return BadRequest("Aluno não encontrado!");
            _context.Remove(aluno);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult HttpPatch(int id, Aluno aluno)
        {   
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }



    }
}