using Microsoft.EntityFrameworkCore.Migrations;

namespace Cybersecurity_Backend.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "email", "lastname", "name", "password", "username" },
                values: new object[] { 1, "a@a.com", "a", "a", "a", "a" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "email", "lastname", "name", "password", "username" },
                values: new object[] { 2, "b@b.com", "b", "b", "b", "b" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "email", "lastname", "name", "password", "username" },
                values: new object[] { 3, "c@c.com", "c", "c", "c", "c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 3);
        }
    }
}
