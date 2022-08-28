using System.Collections.Generic;

namespace CadastroEscolar_WebAPI.Models
{

    public class Aluno
    {
        public Aluno (int id, string nome, string email, string cpf, string telefone, string sexo, string nascimento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Sexo = sexo;
            this.Nascimento = nascimento;
            
        }
      public int Id { get; set; }
      public string Nome { get; set; }
      public string Email { get; set; }
      public string Cpf { get; set; } 
      public string Telefone { get; set; }
      public string Sexo { get; set; } 
      public string Nascimento { get; set; } 
      public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
      
    }
}

