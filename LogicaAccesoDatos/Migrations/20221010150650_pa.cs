using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class pa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeleccionPartidos_Partido_idpartido",
                table: "SeleccionPartidos");

            migrationBuilder.DropForeignKey(
                name: "FK_SeleccionPartidos_Seleccion_idseleccion",
                table: "SeleccionPartidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeleccionPartidos",
                table: "SeleccionPartidos");

            migrationBuilder.RenameTable(
                name: "SeleccionPartidos",
                newName: "SeleccionPartido");

            migrationBuilder.RenameIndex(
                name: "IX_SeleccionPartidos_idseleccion",
                table: "SeleccionPartido",
                newName: "IX_SeleccionPartido_idseleccion");

            migrationBuilder.RenameIndex(
                name: "IX_SeleccionPartidos_idpartido",
                table: "SeleccionPartido",
                newName: "IX_SeleccionPartido_idpartido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeleccionPartido",
                table: "SeleccionPartido",
                column: "id");

            migrationBuilder.CreateTable(
                name: "ResultadoPartido",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idseleccionPartido = table.Column<int>(nullable: false),
                    goles = table.Column<int>(nullable: false),
                    rojas = table.Column<int>(nullable: false),
                    dobleAmarrilla = table.Column<int>(nullable: false),
                    Amarrillas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadoPartido", x => x.id);
                    table.ForeignKey(
                        name: "FK_ResultadoPartido_SeleccionPartido_idseleccionPartido",
                        column: x => x.idseleccionPartido,
                        principalTable: "SeleccionPartido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoPartido_idseleccionPartido",
                table: "ResultadoPartido",
                column: "idseleccionPartido");

            migrationBuilder.AddForeignKey(
                name: "FK_SeleccionPartido_Partido_idpartido",
                table: "SeleccionPartido",
                column: "idpartido",
                principalTable: "Partido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeleccionPartido_Seleccion_idseleccion",
                table: "SeleccionPartido",
                column: "idseleccion",
                principalTable: "Seleccion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeleccionPartido_Partido_idpartido",
                table: "SeleccionPartido");

            migrationBuilder.DropForeignKey(
                name: "FK_SeleccionPartido_Seleccion_idseleccion",
                table: "SeleccionPartido");

            migrationBuilder.DropTable(
                name: "ResultadoPartido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeleccionPartido",
                table: "SeleccionPartido");

            migrationBuilder.RenameTable(
                name: "SeleccionPartido",
                newName: "SeleccionPartidos");

            migrationBuilder.RenameIndex(
                name: "IX_SeleccionPartido_idseleccion",
                table: "SeleccionPartidos",
                newName: "IX_SeleccionPartidos_idseleccion");

            migrationBuilder.RenameIndex(
                name: "IX_SeleccionPartido_idpartido",
                table: "SeleccionPartidos",
                newName: "IX_SeleccionPartidos_idpartido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeleccionPartidos",
                table: "SeleccionPartidos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeleccionPartidos_Partido_idpartido",
                table: "SeleccionPartidos",
                column: "idpartido",
                principalTable: "Partido",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeleccionPartidos_Seleccion_idseleccion",
                table: "SeleccionPartidos",
                column: "idseleccion",
                principalTable: "Seleccion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
