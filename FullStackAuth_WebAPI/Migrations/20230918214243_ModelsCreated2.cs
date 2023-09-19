using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModelsCreated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2984ed2e-ccfb-4024-9a45-aea2f993e5cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b61999a9-5dad-442a-a9ad-85443346c232");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a49386c-1800-4a0a-9881-e3fcbe1e2843", null, "User", "USER" },
                    { "f662bd5b-6c99-4155-b7b7-1e7e1756dfb7", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a49386c-1800-4a0a-9881-e3fcbe1e2843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f662bd5b-6c99-4155-b7b7-1e7e1756dfb7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2984ed2e-ccfb-4024-9a45-aea2f993e5cd", null, "User", "USER" },
                    { "b61999a9-5dad-442a-a9ad-85443346c232", null, "Admin", "ADMIN" }
                });
        }
    }
}
