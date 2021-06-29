using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Health = table.Column<int>(nullable: false),
                    Shield = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    Energy = table.Column<int>(nullable: false),
                    SprintSpeed = table.Column<float>(nullable: false),
                    Polarities = table.Column<string>(nullable: true),
                    ExilusPolarity = table.Column<string>(nullable: true),
                    AuraPolarity = table.Column<string>(nullable: true),
                    SubsumedAbility = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "AuraPolarity", "Energy", "ExilusPolarity", "Health", "Name", "Polarities", "Shield", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 1, 100, "A", 100, "E", 110, "Excalibur", "UAF", 50, 1f, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frames");
        }
    }
}
