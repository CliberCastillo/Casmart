using Microsoft.EntityFrameworkCore.Migrations;

namespace Buses.Migrations
{
    public partial class numero1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PASAJE_IDEMPLEADO",
                table: "Pasaje");

            migrationBuilder.DropForeignKey(
                name: "FK_RESERVA_IDPASAJERO",
                table: "Reserva");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pasaje_Empleado_IdEmpleado",
                table: "Pasaje");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Pasajero_IdPasajero",
                table: "Reserva");
        }
    }
}
