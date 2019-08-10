using Microsoft.EntityFrameworkCore.Migrations;

namespace BracketMap.Web.Migrations
{
    public partial class FixPropSpelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerCout",
                table: "Tournements",
                newName: "PlayerCount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerCount",
                table: "Tournements",
                newName: "PlayerCout");
        }
    }
}
