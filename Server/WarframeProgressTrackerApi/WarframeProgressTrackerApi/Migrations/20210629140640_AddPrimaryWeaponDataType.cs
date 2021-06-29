using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddPrimaryWeaponDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrimaryWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MasteryRankRequired = table.Column<int>(nullable: false),
                    WeaponType = table.Column<string>(nullable: true),
                    AmmoType = table.Column<string>(nullable: true),
                    TriggerType = table.Column<string>(nullable: true),
                    ProjectileType = table.Column<string>(nullable: true),
                    FireRate = table.Column<float>(nullable: false),
                    Accuracy = table.Column<float>(nullable: false),
                    MagazineSize = table.Column<int>(nullable: false),
                    MaxAmmo = table.Column<int>(nullable: false),
                    ReloadSeconds = table.Column<float>(nullable: false),
                    Disposition = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryWeapons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 1, 25f, "Arm Cannon", 0.7f, 3.83f, 27, 0, 0, "Bubunico", "Projectile", 16.875f, "Auto", "Arm Cannon" });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 2, 23.5f, "Rifle", 0.6f, 12f, 48, 8, 96, "Acceltra", "Projectile", 2f, "Auto", "Rifle" });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 3, 9.1f, "Shotgun", 0.9f, 1.42f, 20, 14, 120, "Corinth", "Hit Scan", 3f, "Semi-Auto", "Shotgun" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrimaryWeapons");
        }
    }
}
