using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantApost",
                table: "Seleccion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Seleccion",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Seleccion",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "Seleccion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "paisId",
                table: "Seleccion",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seleccion_paisId",
                table: "Seleccion",
                column: "paisId");

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

            migrationBuilder.DropIndex(
                name: "IX_Seleccion_paisId",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "CantApost",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "paisId",
                table: "Seleccion");
        }
    }
}
