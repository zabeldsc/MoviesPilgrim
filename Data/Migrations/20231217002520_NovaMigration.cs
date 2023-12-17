using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesPilgrim.Data.Migrations
{
    /// <inheritdoc />
    public partial class NovaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(type: "TEXT", nullable: false),
                    sinopse = table.Column<string>(type: "TEXT", nullable: false),
                    valor_filme = table.Column<float>(type: "REAL", nullable: false),
                    taxa_dia = table.Column<float>(type: "REAL", nullable: false),
                    classificacao = table.Column<string>(type: "TEXT", nullable: false),
                    genero = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
