using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroEscolar_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroEscolar_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Aluno>? Alunos { get; set; }
        public DbSet<Professor>? Professores { get; set; }
        public DbSet<Disciplina>? Disciplinas { get; set; }
        public DbSet<AlunoDisciplina>? AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, "Carlos"),
                    new Professor(2, "Ricardo"),
                    new Professor(3, "Tiago"),
                    new Professor(4, "Rubens"),
                    new Professor(5, "Clara"),
                    new Professor(6, "Isabela"),
                    new Professor(7, "Celia"),
                });
            
            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina(1, "Matemática", 1),
                    new Disciplina(2, "Física", 2),
                    new Disciplina(3, "Português", 3),
                    new Disciplina(4, "Inglês", 4),
                    new Disciplina(5, "Programação", 5)
                });
            
            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1, "Raquel Silva", "875.363.800-03", "raquelsilva276@gmail.com", "55119548345", "feminino", "08/09/2004"),
                    new Aluno(2, "Laura Sousa", "875.363.800-03", "laurinhasous@gmail.com", "5511899874", "feminino", "12/10/2003"),
                    new Aluno(3, "Rebeka Vitória", "566.978.230-54", "rbkvitoria245@gmail.com", "5511986549", "feminino", "21/05/2005"),
                    new Aluno(4, "Pedro Henrique", "718.723.720-07", "phenriq24@gmail.com", "5511976548", "masculino", "30/04/2003"),
                    new Aluno(5, "Otávio Porto", "141.133.870-79", "Otvport985@gmail.com", "551154325", "masculino", "16/01/2004"),
                    new Aluno(6, "Luisa Junior", "161.781.950-60", "Juluisa57@gmail.com", "556614124", "feminino", "05/02/2002"),
                    new Aluno(7, "Vitor Nobrega", "778.402.420-73", "VitinhoNobrega924@gmail.com", "556543245", "masculino", "29/07/2004")
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 5 }
                });
        } 
    }
}