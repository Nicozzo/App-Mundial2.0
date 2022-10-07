using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicaAccesoDatos.Migrations
{
    public partial class par : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeleccionesGrupo");

            migrationBuilder.AddColumn<int>(
                name: "IdGrupo",
                table: "Seleccion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seleccion_IdGrupo",
                table: "Seleccion",
                column: "IdGrupo");

            migrationBuilder.AddForeignKey(
                name: "FK_Seleccion_Grupo_IdGrupo",
                table: "Seleccion",
                column: "IdGrupo",
                principalTable: "Grupo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seleccion_Grupo_IdGrupo",
                table: "Seleccion");

            migrationBuilder.DropIndex(
                name: "IX_Seleccion_IdGrupo",
                table: "Seleccion");

            migrationBuilder.DropColumn(
                name: "IdGrupo",
                table: "Seleccion");

            migrationBuilder.CreateTable(
                name: "SeleccionesGrupo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGrupo = table.Column<int>(type: "int", nullable: false),
                    Idseleccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeleccionesGrupo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SeleccionesGrupo_Grupo_IdGrupo",
                        column: x => x.IdGrupo,
                        principalTable: "Grupo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeleccionesGrupo_Seleccion_Idseleccion",
                        column: x => x.Idseleccion,
                        principalTable: "Seleccion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeleccionesGrupo_IdGrupo",
                table: "SeleccionesGrupo",
                column: "IdGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_SeleccionesGrupo_Idseleccion",
                table: "SeleccionesGrupo",
                column: "Idseleccion");
        }
    }
}
