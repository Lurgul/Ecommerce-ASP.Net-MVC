using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.Migrations
{
    /// <inheritdoc />
    public partial class NameFixedDeveloper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlatformPicture",
                table: "Developer",
                newName: "DeveloperPicture");

            migrationBuilder.RenameColumn(
                name: "PlatformName",
                table: "Developer",
                newName: "DeveloperName");

            migrationBuilder.RenameColumn(
                name: "PlatformId",
                table: "Developer",
                newName: "DeveloperId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeveloperPicture",
                table: "Developer",
                newName: "PlatformPicture");

            migrationBuilder.RenameColumn(
                name: "DeveloperName",
                table: "Developer",
                newName: "PlatformName");

            migrationBuilder.RenameColumn(
                name: "DeveloperId",
                table: "Developer",
                newName: "PlatformId");
        }
    }
}
