using Microsoft.EntityFrameworkCore.Migrations;

namespace BracketMap.DAL.Migrations
{
    public partial class updatecountpropnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerCount",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "TeamCount",
                table: "Tournaments");

            migrationBuilder.AddColumn<int>(
                name: "PlayersPerTeam",
                table: "Tournaments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamsPerFight",
                table: "Tournaments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayersPerTeam",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "TeamsPerFight",
                table: "Tournaments");

            migrationBuilder.AddColumn<int>(
                name: "PlayerCount",
                table: "Tournaments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamCount",
                table: "Tournaments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
