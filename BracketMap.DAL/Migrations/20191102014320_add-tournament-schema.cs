using Microsoft.EntityFrameworkCore.Migrations;

namespace BracketMap.DAL.Migrations
{
    public partial class addtournamentschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brackets");

            migrationBuilder.DropColumn(
                name: "Players",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "PlayerCount",
                table: "Tournaments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(nullable: false),
                    Team1Id = table.Column<int>(nullable: false),
                    Team2Id = table.Column<int>(nullable: false),
                    WinnerTeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fights");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerCount",
                table: "Tournaments");

            migrationBuilder.AddColumn<string>(
                name: "Players",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brackets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    Victor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brackets", x => x.Id);
                });
        }
    }
}
