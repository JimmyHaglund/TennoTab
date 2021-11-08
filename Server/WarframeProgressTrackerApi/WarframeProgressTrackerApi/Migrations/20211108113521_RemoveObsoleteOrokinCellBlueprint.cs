using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class RemoveObsoleteOrokinCellBlueprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Orokin Cell", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Orokin Cell", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Orokin Cell", "Salvage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Orokin Cell", "Alloy Plate", "Resource", 50000, "Resource" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Orokin Cell", "Nano Spores", "Resource", 50000, "Resource" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Orokin Cell", "Salvage", "Resource", 25000, "Resource" });
        }
    }
}
