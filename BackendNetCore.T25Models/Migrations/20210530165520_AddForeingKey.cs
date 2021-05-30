using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendNetCore.T25Models.Migrations
{
    public partial class AddForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Salas_PeliculaId",
                table: "Salas",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplados_DepartamentoId",
                table: "Emplados",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cajas_AlmacenId",
                table: "Cajas",
                column: "AlmacenId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_FabricanteId",
                table: "Articulos",
                column: "FabricanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Fabricante_FabricanteId",
                table: "Articulos",
                column: "FabricanteId",
                principalTable: "Fabricante",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cajas_Almacenes_AlmacenId",
                table: "Cajas",
                column: "AlmacenId",
                principalTable: "Almacenes",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emplados_Departamentos_DepartamentoId",
                table: "Emplados",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Peliculas_PeliculaId",
                table: "Salas",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Fabricante_FabricanteId",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cajas_Almacenes_AlmacenId",
                table: "Cajas");

            migrationBuilder.DropForeignKey(
                name: "FK_Emplados_Departamentos_DepartamentoId",
                table: "Emplados");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Peliculas_PeliculaId",
                table: "Salas");

            migrationBuilder.DropIndex(
                name: "IX_Salas_PeliculaId",
                table: "Salas");

            migrationBuilder.DropIndex(
                name: "IX_Emplados_DepartamentoId",
                table: "Emplados");

            migrationBuilder.DropIndex(
                name: "IX_Cajas_AlmacenId",
                table: "Cajas");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_FabricanteId",
                table: "Articulos");
        }
    }
}
