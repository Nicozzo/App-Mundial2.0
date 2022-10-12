using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultadoPartido_Partido_idpartido",
                table: "ResultadoPartido");

            migrationBuilder.DropIndex(
                name: "IX_ResultadoPartido_idpartido",
                table: "ResultadoPartido");

            migrationBuilder.DropColumn(
                name: "idpartido",
                table: "ResultadoPartido");

            migrationBuilder.AddColumn<int>(
                name: "idseleccion",
                table: "ResultadoPartido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idpartido",
                table: "Incidencia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoPartido_idseleccion",
                table: "ResultadoPartido",
                column: "idseleccion");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencia_idpartido",
                table: "Incidencia",
                column: "idpartido");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidencia_Partido_idpartido",
                table: "Incidencia",
                column: "idpartido",
                principalTable: "Partido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResultadoPartido_Seleccion_idseleccion",
                table: "ResultadoPartido",
                column: "idseleccion",
                principalTable: "Seleccion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidencia_Partido_idpartido",
                table: "Incidencia");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultadoPartido_Seleccion_idseleccion",
                table: "ResultadoPartido");

            migrationBuilder.DropIndex(
                name: "IX_ResultadoPartido_idseleccion",
                table: "ResultadoPartido");

            migrationBuilder.DropIndex(
                name: "IX_Incidencia_idpartido",
                table: "Incidencia");

            migrationBuilder.DropColumn(
                name: "idseleccion",
                table: "ResultadoPartido");

            migrationBuilder.DropColumn(
                name: "idpartido",
                table: "Incidencia");

            migrationBuilder.AddColumn<int>(
                name: "idpartido",
                table: "ResultadoPartido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoPartido_idpartido",
                table: "ResultadoPartido",
                column: "idpartido");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultadoPartido_Partido_idpartido",
                table: "ResultadoPartido",
                column: "idpartido",
                principalTable: "Partido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
