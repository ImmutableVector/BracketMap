using Microsoft.EntityFrameworkCore.Migrations;

namespace BracketMap.Web.Migrations
{
    public partial class AddPropToNodeMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Victor",
                table: "NodeMaps",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Victor",
                table: "NodeMaps");
        }
    }
}
