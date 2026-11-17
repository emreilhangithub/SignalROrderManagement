using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class UpdateFeatureColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titlel",
                table: "Features",
                newName: "Title1");

            migrationBuilder.RenameColumn(
                name: "Descriptionl",
                table: "Features",
                newName: "Description1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title1",
                table: "Features",
                newName: "Titlel");

            migrationBuilder.RenameColumn(
                name: "Description1",
                table: "Features",
                newName: "Descriptionl");
        }
    }
}
