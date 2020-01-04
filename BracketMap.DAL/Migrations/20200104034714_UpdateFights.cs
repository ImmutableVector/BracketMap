using Microsoft.EntityFrameworkCore.Migrations;

namespace BracketMap.DAL.Migrations
{
    public partial class UpdateFights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FightTeamMap_Fights_FightId",
                table: "FightTeamMap");

            migrationBuilder.DropForeignKey(
                name: "FK_FightTeamMap_Teams_TeamId",
                table: "FightTeamMap");

            migrationBuilder.AddForeignKey(
                name: "FK_FightTeamMap_Fights_FightId",
                table: "FightTeamMap",
                column: "FightId",
                principalTable: "Fights",
                principalColumn: "FightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FightTeamMap_Teams_TeamId",
                table: "FightTeamMap",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FightTeamMap_Fights_FightId",
                table: "FightTeamMap");

            migrationBuilder.DropForeignKey(
                name: "FK_FightTeamMap_Teams_TeamId",
                table: "FightTeamMap");

            migrationBuilder.AddForeignKey(
                name: "FK_FightTeamMap_Fights_FightId",
                table: "FightTeamMap",
                column: "FightId",
                principalTable: "Fights",
                principalColumn: "FightId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FightTeamMap_Teams_TeamId",
                table: "FightTeamMap",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
