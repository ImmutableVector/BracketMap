using Microsoft.EntityFrameworkCore.Migrations;

namespace BracketMap.DAL.Migrations
{
    public partial class fightupdatemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Fights_TournamentId",
                table: "Fights",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fights_Tournaments_TournamentId",
                table: "Fights",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fights_Tournaments_TournamentId",
                table: "Fights");

            migrationBuilder.DropIndex(
                name: "IX_Fights_TournamentId",
                table: "Fights");
        }
    }
}
