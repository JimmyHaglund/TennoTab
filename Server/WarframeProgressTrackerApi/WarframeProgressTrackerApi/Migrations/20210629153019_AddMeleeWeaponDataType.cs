using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddMeleeWeaponDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeleeWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MasteryRankRequired = table.Column<int>(nullable: false),
                    WeaponType = table.Column<string>(nullable: true),
                    RangeMetres = table.Column<float>(nullable: false),
                    AttackSpeed = table.Column<float>(nullable: false),
                    BlockAngleDegrees = table.Column<int>(nullable: false),
                    ComboSeconds = table.Column<float>(nullable: false),
                    FollowThrough = table.Column<float>(nullable: false),
                    Disposition = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeleeWeapons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 1, 0.833f, 55, 5f, 1.3f, 0.6f, 0, "Skana", 2.5f, "Sword" });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 2, 1.17f, 50, 5f, 1.45f, 0.9f, 2, "Ankyros", 1.25f, "Fist" });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 3, 1f, 45, 5f, 1.43f, 0.9f, 3, "Ceramic Dagger", 1.8f, "Dagger" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeleeWeapons");
        }
    }
}
