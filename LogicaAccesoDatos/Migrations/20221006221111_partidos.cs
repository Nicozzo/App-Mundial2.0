using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class partidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SeleccionPartidos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idseleccion = table.Column<int>(nullable: false),
                    idpartido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeleccionPartidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_SeleccionPartidos_Partido_idpartido",
                        column: x => x.idpartido,
                        principalTable: "Partido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeleccionPartidos_Seleccion_idseleccion",
                        column: x => x.idseleccion,
                        principalTable: "Seleccion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeleccionPartidos_idpartido",
                table: "SeleccionPartidos",
                column: "idpartido");

            migrationBuilder.CreateIndex(
                name: "IX_SeleccionPartidos_idseleccion",
                table: "SeleccionPartidos",
                column: "idseleccion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeleccionPartidos");

            migrationBuilder.DropTable(
                name: "Partido");
        }
    }
}
