using Microsoft.EntityFrameworkCore.Migrations;

namespace DBFirstSpp.Models.Migrations
{
    public partial class FluentTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Uruns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_CategoryID",
                table: "Uruns",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_Category_CategoryID",
                table: "Uruns",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_Category_CategoryID",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_CategoryID",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Uruns");
        }
    }
}
