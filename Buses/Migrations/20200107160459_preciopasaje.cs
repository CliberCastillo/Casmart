using Microsoft.EntityFrameworkCore.Migrations;

namespace Buses.Migrations
{
    public partial class preciopasaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "precioPasaje",
                table: "Pasaje",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "precioPasaje",
                table: "Pasaje");
        }
    }
}
