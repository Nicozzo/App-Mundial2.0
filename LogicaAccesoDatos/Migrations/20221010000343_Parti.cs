using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class Parti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeleccionPartidos");

            migrationBuilder.AddColumn<int>(
                name: "idSelccionLocal",
                table: "Partido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSelccionVisitante",
                table: "Partido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Partido_idSelccionLocal",
                table: "Partido",
                column: "idSelccionLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_idSelccionVisitante",
                table: "Partido",
                column: "idSelccionVisitante");

            migrationBuilder.AddForeignKey(
                name: "FK_Partido_Seleccion_idSelccionLocal",
                table: "Partido",
                column: "idSelccionLocal",
                principalTable: "Seleccion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partido_Seleccion_idSelccionVisitante",
                table: "Partido",
                column: "idSelccionVisitante",
                principalTable: "Seleccion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partido_Seleccion_idSelccionLocal",
                table: "Partido");

            migrationBuilder.DropForeignKey(
                name: "FK_Partido_Seleccion_idSelccionVisitante",
                table: "Partido");

            migrationBuilder.DropIndex(
                name: "IX_Partido_idSelccionLocal",
                table: "Partido");

            migrationBuilder.DropIndex(
                name: "IX_Partido_idSelccionVisitante",
                table: "Partido");

            migrationBuilder.DropColumn(
                name: "idSelccionLocal",
                table: "Partido");

            migrationBuilder.DropColumn(
                name: "idSelccionVisitante",
                table: "Partido");

            migrationBuilder.CreateTable(
                name: "SeleccionPartidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idpartido = table.Column<int>(type: "int", nullable: false),
                    idseleccion = table.Column<int>(type: "int", nullable: false)
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
    }
}
