using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_Login_System.Migrations
{
    /// <inheritdoc />
    public partial class uniqueemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_emailAddress",
                table: "Users",
                column: "emailAddress",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_emailAddress",
                table: "Users");
        }
    }
}
