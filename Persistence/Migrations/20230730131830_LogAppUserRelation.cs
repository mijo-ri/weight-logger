using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class LogAppUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Logs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logs_AppUserId",
                table: "Logs",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_AspNetUsers_AppUserId",
                table: "Logs",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_AspNetUsers_AppUserId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_AppUserId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Logs");
        }
    }
}
