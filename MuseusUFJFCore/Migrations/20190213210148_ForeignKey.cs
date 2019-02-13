using Microsoft.EntityFrameworkCore.Migrations;

namespace MuseusUFJFCore.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_Section_SectionId",
                table: "Collection");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Unit_UnitId",
                table: "Section");

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "Section",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Collection",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Section_SectionId",
                table: "Collection",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Unit_UnitId",
                table: "Section",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collection_Section_SectionId",
                table: "Collection");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Unit_UnitId",
                table: "Section");

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "Section",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Collection",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Collection_Section_SectionId",
                table: "Collection",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Unit_UnitId",
                table: "Section",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
