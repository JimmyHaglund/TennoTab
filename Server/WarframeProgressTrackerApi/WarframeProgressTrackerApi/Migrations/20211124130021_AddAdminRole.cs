using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fbb0cad-2fd4-4f4c-8563-f9c98c0f2eca", "dfe4ef23-6568-419e-9731-8bca58825bc5", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be94eee5-75d3-4bc3-b568-a97673a82c8b", "eb171ac7-0029-4418-839e-2081a7957ad6", "User", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fbb0cad-2fd4-4f4c-8563-f9c98c0f2eca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be94eee5-75d3-4bc3-b568-a97673a82c8b");
        }
    }
}
