using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroEscolar_WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    cpf = table.Column<string>(type: "TEXT", nullable: true),
                    telefone = table.Column<string>(type: "TEXT", nullable: true),
                    sexo = table.Column<string>(type: "TEXT", nullable: true),
                    nascimento = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    ProfessorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplinaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "cpf", "email", "nascimento", "nome", "sexo", "telefone" },
                values: new object[] { 1, "raquelsilva276@gmail.com", "875.363.800-03", "08/09/2004", "Raquel Silva", "feminino", "55119548345" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "cpf", "email", "nascimento", "nome", "sexo", "telefone" },
                values: new object[] { 2, "laurinhasous@gmail.com", "875.363.800-03", "12/10/2003", "Laura Sousa", "feminino", "5511899874" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "cpf", "email", "nascimento", "nome", "sexo", "telefone" },
                values: new object[] { 3, "rbkvitoria245@gmail.com", "566.978.230-54", "21/05/2005", "Rebeka Vitória", "feminino", "5511986549" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "cpf", "email", "nascimento", "nome", "sexo", "telefone" },
                values: new object[] { 4, "phenriq24@gmail.com", "718.723.720-07", "30/04/2003", "Pedro Henrique", "masculino", "5511976548" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "cpf", "email", "nascimento", "nome", "sexo", "telefone" },
                values: new object[] { 5, "Otvport985@gmail.com", "141.133.870-79", "16/01/2004", "Otávio Porto", "masculino", "551154325" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "cpf", "email", "nascimento", "nome", "sexo", "telefone" },
                values: new object[] { 6, "Juluisa57@gmail.com", "161.781.950-60", "05/02/2002", "Luisa Junior", "feminino", "556614124" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "cpf", "email", "nascimento", "nome", "sexo", "telefone" },
                values: new object[] { 7, "VitinhoNobrega924@gmail.com", "778.402.420-73", "29/07/2004", "Vitor Nobrega", "masculino", "556543245" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 1, "Carlos" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 2, "Ricardo" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 3, "Tiago" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 4, "Rubens" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 5, "Clara" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 6, "Isabela" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 7, "Celia" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 1, "Matemática", 1 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 2, "Física", 2 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 3, "Português", 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 4, "Inglês", 4 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 5, "Programação", 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
