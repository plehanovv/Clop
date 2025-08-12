using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddNewHasManyUserProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Profile_UserId",
                table: "Profile");

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "Address", "Age", "UserId" },
                values: new object[] { 2L, "Kukushkina 43", 31, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Profile_UserId",
                table: "Profile");

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId",
                unique: true);
        }
    }
}
