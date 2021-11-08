using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class ChangeAtlasComponentTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Atlas", "Atlas Chassis" },
                column: "ComponentCategory",
                value: "Component");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Atlas", "Atlas Neuroptics" },
                column: "ComponentCategory",
                value: "Component");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Atlas", "Atlas Systems" },
                column: "ComponentCategory",
                value: "Component");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Atlas", "Atlas Chassis" },
                column: "ComponentCategory",
                value: "Resource");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Atlas", "Atlas Neuroptics" },
                column: "ComponentCategory",
                value: "Resource");

            migrationBuilder.UpdateData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Atlas", "Atlas Systems" },
                column: "ComponentCategory",
                value: "Resource");
        }
    }
}
