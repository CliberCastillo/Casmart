using Microsoft.EntityFrameworkCore.Migrations;

namespace Buses.Migrations
{
    public partial class NumeroAsientos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionViaje",
                table: "ItinerarioViaje");

            migrationBuilder.AddColumn<int>(
                name: "NumeroAsieto",
                table: "Pasaje",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
