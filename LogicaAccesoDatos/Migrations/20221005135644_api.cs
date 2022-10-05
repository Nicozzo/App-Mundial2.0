using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class api : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion");

            migrationBuilder.AlterColumn<int>(
                name: "paisId",
                table: "Seleccion",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion",
                column: "paisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion");

            migrationBuilder.AlterColumn<int>(
                name: "paisId",
                table: "Seleccion",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seleccion_Pais_paisId",
                table: "Seleccion",
                column: "paisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
