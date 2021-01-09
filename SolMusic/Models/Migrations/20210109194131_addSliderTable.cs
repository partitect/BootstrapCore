using Microsoft.EntityFrameworkCore.Migrations;

namespace SolMusic.Models.Migrations
{
    public partial class addSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    btnTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    btnLink1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    btnTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    btnLink2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slides");
        }
    }
}
