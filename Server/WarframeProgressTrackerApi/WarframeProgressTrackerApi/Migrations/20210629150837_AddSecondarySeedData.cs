using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddSecondarySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 1, 33.33f, "Pistol", 1.52f, 8.33f, 60, 4, 420, "Cestra", "Projectile", 2f, "Auto", "Pistol" });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 2, 16f, "Pistol", 1.25f, 1.08f, 6, 3, 210, "Lex", "Hit Scan", 2.35f, "Semi-Auto", "Pistol" });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 3, 5f, "Shotgun Sidearm", 0.95f, 4.17f, 10, 12, 210, "Pyrana", "Hit Scan", 2f, "Auto", "Shotgun Sidearm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
