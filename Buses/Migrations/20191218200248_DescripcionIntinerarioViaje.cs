using Microsoft.EntityFrameworkCore.Migrations;

namespace Buses.Migrations
{
    public partial class DescripcionIntinerarioViaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescripcionViaje",
                table: "ItinerarioViaje",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionViaje",
                table: "ItinerarioViaje");
        }
    }
}
