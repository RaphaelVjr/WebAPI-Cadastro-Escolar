using System.Collections.Generic;

namespace CadastroEscolar_WebAPI.Models
{
    public class Disciplina
    {
        public Disciplina() { }
        public Disciplina(int id, string nome, int professorId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
        }
        public int Id { get; set; } 
        public string Nome { get; set; } = default!;
        public int ProfessorId { get; set; } = default!;
        public Professor Professor { get; set; } = default!;
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; } = default!;
    }
}