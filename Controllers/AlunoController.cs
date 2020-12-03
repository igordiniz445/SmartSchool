using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {

        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(1,"Lucas","Alfredo","321432112"),
            new Aluno(2,"Igor","Otávio","32141212"),
            new Aluno(3,"Julia","Oliveira","32153215")
        };

        public AlunoController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.Find(a => a.Id.Equals(id));
            if(aluno == null){return BadRequest("Aluno não encontrado");}
            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome)
        {
            var aluno = Alunos.Find(a => a.Nome.Equals(nome));
            if(aluno == null){return BadRequest("Aluno não encontrado");}
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult HttpPatch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }



    }
}