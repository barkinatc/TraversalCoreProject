using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Contacts",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "MapLocation",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Contacts",
                newName: "Body");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Contacts",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "MapLocation");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Contacts",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
