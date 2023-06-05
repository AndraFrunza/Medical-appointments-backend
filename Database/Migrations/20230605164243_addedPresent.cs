using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class addedPresent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Present",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Present",
                table: "Appointments");
        }
    }
}
