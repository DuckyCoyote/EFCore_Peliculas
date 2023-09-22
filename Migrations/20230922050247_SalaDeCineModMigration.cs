using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace EFCore_Peliculas.Migrations
{
    /// <inheritdoc />
    public partial class SalaDeCineModMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalasDeCine_CineOfertas_CineOfertaId",
                table: "SalasDeCine");

            migrationBuilder.DropIndex(
                name: "IX_SalasDeCine_CineOfertaId",
                table: "SalasDeCine");

            migrationBuilder.DropColumn(
                name: "CineOfertaId",
                table: "SalasDeCine");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "SalasDeCine");

            migrationBuilder.AddColumn<int>(
                name: "CineId",
                table: "SalasDeCine",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoSalaDeCine",
                table: "SalasDeCine",
                type: "integer",
                nullable: false,
                defaultValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CineId",
                table: "SalasDeCine");

            migrationBuilder.DropColumn(
                name: "TipoSalaDeCine",
                table: "SalasDeCine");

            migrationBuilder.AddColumn<int>(
                name: "CineOfertaId",
                table: "SalasDeCine",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Point>(
                name: "Ubicacion",
                table: "SalasDeCine",
                type: "geometry",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalasDeCine_CineOfertaId",
                table: "SalasDeCine",
                column: "CineOfertaId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalasDeCine_CineOfertas_CineOfertaId",
                table: "SalasDeCine",
                column: "CineOfertaId",
                principalTable: "CineOfertas",
                principalColumn: "Id");
        }
    }
}
