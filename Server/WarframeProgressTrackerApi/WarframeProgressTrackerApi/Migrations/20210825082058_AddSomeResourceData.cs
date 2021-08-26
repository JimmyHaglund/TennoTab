using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddSomeResourceData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[,]
                {
                    { "Ash Neuroptics", "Credits", "Resource", 15000, "Component" },
                    { "Ash Neuroptics", "Alloy Plate", "Resource", 150, "Component" },
                    { "Ash Neuroptics", "Neural Sensors", "Resource", 1, "Component" },
                    { "Ash Neuroptics", "Polymer Bundle", "Resource", 150, "Component" },
                    { "Ash Neuroptics", "Rubedo", "Resource", 500, "Component" }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 587, "Rubedo" },
                    { 588, "Credits" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 588);
        }
    }
}
