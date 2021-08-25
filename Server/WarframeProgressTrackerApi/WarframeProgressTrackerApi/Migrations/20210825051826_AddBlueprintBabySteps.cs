using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddBlueprintBabySteps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintResources",
                columns: table => new
                {
                    ResultId = table.Column<int>(nullable: false),
                    ResultCategory = table.Column<string>(nullable: false),
                    ComponentId = table.Column<int>(nullable: false),
                    ComponentCategory = table.Column<string>(nullable: true),
                    ComponentCount = table.Column<int>(nullable: false),
                    ResourceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintResources", x => new { x.ResultId, x.ResultCategory });
                    table.ForeignKey(
                        name: "FK_BlueprintResources_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintResources_ResourceId",
                table: "BlueprintResources",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlueprintResources");

            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}
