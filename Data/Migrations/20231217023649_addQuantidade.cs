using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesPilgrim.Data.Migrations
{
    /// <inheritdoc />
    public partial class addQuantidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantidade",
                table: "Filmes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantidade",
                table: "Filmes");
        }
    }
}
