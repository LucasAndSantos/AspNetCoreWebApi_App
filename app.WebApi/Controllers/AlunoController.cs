using System.Collections.Generic;
using System.Linq;
using app.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Lucas",
                Sobrenome = "Santos",
                Telefone = "135468431"
            },
             new Aluno(){
                Id = 2,
                Nome = "Andre",
                Sobrenome = "Silva",
                Telefone = "456789123"
            },
             new Aluno(){
                Id = 3,
                Nome = "Matheus",
                Sobrenome = "Andrade",
                Telefone = "78945613"
            },
        };
        public AlunoController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        // api/aluno/byId?id=1
        [HttpGet("ById/{Id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if(aluno == null) return BadRequest("O Aluno não foi encontrado");

            return Ok(aluno);
        }

        // api/aluno/nome
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(aluno =>
             aluno.Nome.Contains(nome) && aluno.Sobrenome.Contains(Sobrenome));
            if(aluno == null) return BadRequest("O Aluno não foi encontrado");
            
            return Ok(aluno);
        }

        // api/aluno/nome
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

         // api/aluno/nome
        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // api/aluno/nome
        [HttpPatch("{Id}")]
        public IActionResult Patch(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

         // api/aluno/nome
        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
        

    }
}