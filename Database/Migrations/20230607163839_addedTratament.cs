using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class addedTratament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tratament",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tratament",
                table: "Appointments");
        }
    }
}
