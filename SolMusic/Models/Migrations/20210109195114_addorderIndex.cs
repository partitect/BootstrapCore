using Microsoft.EntityFrameworkCore.Migrations;

namespace SolMusic.Models.Migrations
{
    public partial class addorderIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "orderIndex",
                table: "Slides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "orderIndex",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderIndex",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "orderIndex",
                table: "Pages");
        }
    }
}
