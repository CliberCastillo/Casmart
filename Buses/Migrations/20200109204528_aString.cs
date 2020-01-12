using Microsoft.EntityFrameworkCore.Migrations;

namespace Buses.Migrations
{
    public partial class aString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroAsieto",
                table: "Pasaje",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumeroAsieto",
                table: "Pasaje",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
