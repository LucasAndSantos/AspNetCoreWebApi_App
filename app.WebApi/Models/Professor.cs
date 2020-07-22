using System.Collections.Generic;

namespace app.WebApi.Models
{
    public class Professor
    {
        public Professor() { }
        public Professor(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Dsciplinas { get; set; }
    }
}