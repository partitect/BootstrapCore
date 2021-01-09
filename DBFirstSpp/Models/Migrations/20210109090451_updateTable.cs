using Microsoft.EntityFrameworkCore.Migrations;

namespace DBFirstSpp.Models.Migrations
{
    public partial class updateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler");

            migrationBuilder.RenameTable(
                name: "Urunler",
                newName: "Uruns");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Uruns",
                type: "decimal(18,3)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Uruns",
                type: "Varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayIndex",
                table: "Uruns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uruns",
                table: "Uruns",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Uruns",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "DisplayIndex",
                table: "Uruns");

            migrationBuilder.RenameTable(
                name: "Uruns",
                newName: "Urunler");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Urunler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler",
                column: "ID");
        }
    }
}
