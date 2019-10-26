using Microsoft.EntityFrameworkCore.Migrations;

namespace BracketMap.DAL.Migrations
{
    public partial class teamtableupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerCount",
                table: "Tournaments");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Teams",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "PlayerCount",
                table: "Tournaments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
