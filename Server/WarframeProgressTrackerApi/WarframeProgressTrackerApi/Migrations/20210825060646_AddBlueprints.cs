using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddBlueprints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlueprintResources",
                table: "BlueprintResources");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "BlueprintResources");

            migrationBuilder.DropColumn(
                name: "ComponentId",
                table: "BlueprintResources");

            migrationBuilder.AlterColumn<string>(
                name: "ResultCategory",
                table: "BlueprintResources",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ResultName",
                table: "BlueprintResources",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ComponentName",
                table: "BlueprintResources",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlueprintResources",
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[,]
                {
                    { "Ash", "Ash Neuroptics", "Resource", 1, "Warframe" },
                    { "Ash", "Ash Chassis", "Resource", 1, "Warframe" },
                    { "Ash", "Ash Systems", "Resource", 1, "Warframe" },
                    { "Orokin Cell", "Alloy Plate", "Resource", 50000, "Resource" },
                    { "Orokin Cell", "Nano Spores", "Resource", 50000, "Resource" },
                    { "Orokin Cell", "Salvage", "Resource", 25000, "Resource" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlueprintResources",
                table: "BlueprintResources");

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Chassis" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Neuroptics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ResultName", "ComponentName" },
                keyValues: new object[] { "Ash", "Ash Systems" });

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

            migrationBuilder.DropColumn(
                name: "ResultName",
                table: "BlueprintResources");

            migrationBuilder.DropColumn(
                name: "ComponentName",
                table: "BlueprintResources");

            migrationBuilder.AlterColumn<string>(
                name: "ResultCategory",
                table: "BlueprintResources",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "BlueprintResources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComponentId",
                table: "BlueprintResources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlueprintResources",
                table: "BlueprintResources",
                columns: new[] { "ResultId", "ResultCategory" });
        }
    }
}
