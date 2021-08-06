using Microsoft.EntityFrameworkCore.Migrations;

namespace Series.Mvc.Migrations
{
    public partial class RenameDescricaoInSerieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrica",
                table: "Series",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Series",
                newName: "Descrica");
        }
    }
}
