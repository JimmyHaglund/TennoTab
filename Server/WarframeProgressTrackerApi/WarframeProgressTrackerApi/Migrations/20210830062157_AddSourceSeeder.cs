using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddSourceSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    ItemCategory = table.Column<string>(nullable: true),
                    SourceName = table.Column<string>(nullable: true),
                    SourceType = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[,]
                {
                    { 1, "Blueprint", "Ash Blueprint", "Market", "Market", "35000" },
                    { 2, "Blueprint", "Ash Neuroptics Blueprint", "Grineer Manic", "Drop", "12.78" },
                    { 3, "Blueprint", "Ash Chassis Blueprint", "Grineer Manic", "Drop", "12.78" },
                    { 4, "Blueprint", "Ash Systems Blueprint", "Grineer Manic", "Drop", "7.44" },
                    { 5, "Blueprint", "Ash Prime Neuroptics Blueprint", "Axi N2", "Relic", "Uncommon" },
                    { 6, "Blueprint", "Ash Prime Neuroptics Blueprint", "Meso N2", "Relic", "Uncommon" },
                    { 7, "Blueprint", "Ash Prime Neuroptics Blueprint", "Meso V4", "Relic", "Uncommon" },
                    { 8, "Blueprint", "Ash Prime Neuroptics Blueprint", "Neo A4", "Relic", "Uncommon" },
                    { 9, "Blueprint", "Ash Prime Neuroptics Blueprint", "Neo N3", "Relic", "Uncommon" },
                    { 10, "Blueprint", "Ash Prime Neuroptics Blueprint", "Neo V4", "Relic", "Uncommon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
