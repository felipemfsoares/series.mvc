using Microsoft.EntityFrameworkCore.Migrations;

namespace Series.Mvc.Migrations
{
    public partial class AddGeneroInSerie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Series",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Series");
        }
    }
}
