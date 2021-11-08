using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class TestBlueprintFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Chassis" },
                column: "ComponentCategory",
                value: "Component");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Neuroptics" },
                column: "ComponentCategory",
                value: "Component");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Systems" },
                column: "ComponentCategory",
                value: "Component");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Chassis" },
                column: "ComponentCategory",
                value: "Resource");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Neuroptics" },
                column: "ComponentCategory",
                value: "Resource");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Systems" },
                column: "ComponentCategory",
                value: "Resource");
        }
    }
}
