using Microsoft.EntityFrameworkCore.Migrations;

namespace umbrella.Migrations
{
    public partial class AddingUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cell",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Cell",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "User");
        }
    }
}
