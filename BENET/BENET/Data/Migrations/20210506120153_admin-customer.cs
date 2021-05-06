using Microsoft.EntityFrameworkCore.Migrations;

namespace BENET.Data.Migrations
{
    public partial class admincustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Preferences",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer_Username",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "User",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Preferences",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Customer_Username",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "User");
        }
    }
}
