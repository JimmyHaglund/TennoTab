using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class SeedPrimaryWeaponFromCsv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[,]
                {
                    { 31, 175, 1f, "V", 150, 1.5f, "", 125, 3f, "", 0, "Oberon", "VV", 100, 3f, 1f, 0 },
                    { 58, 275, 1f, "B", 150, 1.5f, "", 100, 3f, "", 0, "Hydroid Prime", "VDBB", 175, 3f, 1.05f, 0 },
                    { 59, 225, 1f, "B", 125, 1.5f, "B", 575, 4f, "", 0, "Inaros Prime", "VDD", 0, 3f, 1.05f, 0 },
                    { 60, 125, 1f, "B", 200, 1.5f, "", 75, 3f, "", 0, "Ivara Prime", "VDB", 150, 3f, 1.2f, 0 },
                    { 61, 125, 1f, "B", 175, 1.5f, "", 100, 3f, "", 0, "Limbo Prime", "VVBD", 100, 3f, 1.15f, 0 },
                    { 62, 125, 1f, "B", 175, 1.5f, "", 75, 3f, "", 0, "Loki Prime", "DDVB", 75, 3f, 1.25f, 0 },
                    { 63, 125, 1f, "V", 175, 1.5f, "", 100, 3f, "", 0, "Mag Prime", "BBV", 150, 3f, 1f, 0 },
                    { 64, 125, 1f, "V", 125, 1.5f, "", 135, 3f, "", 0, "Mesa Prime", "BBDV", 75, 3f, 1.1f, 0 },
                    { 65, 175, 1f, "B", 150, 1.5f, "", 80, 3f, "", 0, "Mirage Prime", "DDBV", 110, 3f, 1.2f, 0 },
                    { 66, 125, 1f, "", 125, 1.5f, "", 100, 3f, "", 0, "Nekros Prime", "VDB", 150, 3f, 1.1f, 0 },
                    { 67, 250, 1f, "B", 150, 1.5f, "", 125, 3f, "", 0, "Nezha Prime", "DVB", 50, 3f, 1.2f, 0 },
                    { 57, 190, 1f, "D", 150, 1.5f, "", 120, 3f, "", 0, "Gara Prime", "VVB", 100, 3f, 1.15f, 0 },
                    { 68, 125, 1f, "B", 175, 1.5f, "", 100, 3f, "", 0, "Nova Prime", "VVV", 100, 3f, 1.2f, 0 },
                    { 71, 150, 1f, "B", 175, 1.5f, "", 100, 3f, "", 0, "Octavia Prime", "DBB", 100, 3f, 1.05f, 0 },
                    { 72, 275, 1f, "V", 100, 1.5f, "", 100, 3f, "", 0, "Rhino Prime", "DDB", 150, 3f, 1f, 0 },
                    { 73, 300, 1f, "D", 200, 1.5f, "", 125, 3f, "", 0, "Saryn Prime", "BDV", 100, 3f, 1f, 0 },
                    { 74, 125, 1f, "V", 175, 1.5f, "", 125, 3f, "", 2, "Octavia Prime", "BVVD", 100, 3f, 1f, 0 },
                    { 75, 125, 1f, "D", 150, 1.5f, "", 100, 3f, "", 0, "Trinity Prime", "DDVB", 150, 3f, 1.1f, 0 },
                    { 76, 700, 1f, "V", 150, 1.5f, "", 100, 3f, "", 0, "Valkyr Prime", "VVV", 50, 3f, 1.1f, 0 },
                    { 77, 200, 1f, "B", 150, 1.5f, "", 100, 3f, "", 0, "Vauban Prime", "BVD", 100, 3f, 1f, 0 },
                    { 78, 125, 1f, "V", 200, 1.5f, "", 100, 3f, "", 0, "Volt Prime", "BVV", 150, 3f, 1f, 0 },
                    { 79, 275, 1f, "V", 130, 1.5f, "", 150, 3f, "", 5, "Wukong Prime", "BDV", 120, 3f, 1.05f, 0 },
                    { 80, 125, 1f, "D", 150, 1.5f, "", 150, 3f, "", 6, "Zephyr Prime", "VVDB", 150, 3f, 1.2f, 0 },
                    { 69, 125, 1f, "B", 150, 1.5f, "", 100, 3f, "", 0, "Nyx Prime", "VBD", 125, 3f, 1.125f, 0 },
                    { 56, 300, 1f, "D", 100, 1.5f, "", 100, 3f, "", 0, "Frost Prime", "BDD", 175, 3f, 0.95f, 0 },
                    { 70, 225, 1f, "V", 175, 1.5f, "", 125, 3f, "", 8, "Oberon Prime", "BBVV", 100, 3f, 1f, 0 },
                    { 54, 300, 1f, "V", 150, 1.5f, "", 100, 3f, "", 0, "Excalibur Prime", "DVV", 100, 3f, 1f, 0 },
                    { 32, 150, 1f, "B", 150, 1.5f, "", 100, 3f, "", 0, "Octavia", "BB", 75, 3f, 1.05f, 0 },
                    { 33, 125, 1f, "O", 150, 1.5f, "", 100, 3f, "", 0, "Protea", "VB", 150, 3f, 1.2f, 0 },
                    { 34, 125, 1f, "B", 125, 1.5f, "", 100, 3f, "", 0, "Revenant", "VD", 225, 3f, 1f, 0 },
                    { 35, 225, 1f, "V", 100, 1.5f, "", 100, 3f, "", 0, "Rhino", "DD", 150, 3f, 0.95f, 0 },
                    { 36, 225, 1f, "D", 150, 1.5f, "", 125, 3f, "", 0, "Saryn", "BD", 100, 3f, 0.95f, 0 },
                    { 37, 150, 1f, "", 125, 1.5f, "", 100, 3f, "", 0, "Sevagoth", "DV", 90, 3f, 0.95f, 0 },
                    { 38, 100, 1f, "V", 150, 1.5f, "", 100, 3f, "", 0, "Titania", "VD", 100, 3f, 1f, 0 },
                    { 39, 100, 1f, "D", 150, 1.5f, "", 100, 3f, "", 0, "Trinity", "DD", 100, 3f, 1.1f, 0 },
                    { 40, 600, 1f, "V", 150, 1.5f, "", 100, 3f, "", 0, "Valkyr", "VV", 50, 3f, 1.1f, 0 },
                    { 41, 150, 1f, "B", 150, 1.5f, "", 100, 3f, "", 0, "Vauban", "BV", 75, 3f, 1f, 0 },
                    { 42, 100, 1f, "V", 100, 1.5f, "", 100, 3f, "", 0, "Volt", "BV", 150, 3f, 1.1f, 0 },
                    { 44, 250, 1f, "V", 120, 1.5f, "", 150, 3f, "", 0, "Wukong", "BD", 100, 3f, 1f, 0 },
                    { 45, 137, 1f, "B", 153, 1.5f, "", 97, 3f, "", 0, "Xaku", "DD", 89, 3f, 1.02f, 0 },
                    { 46, 100, 1f, "V", 200, 1.5f, "", 100, 3f, "", 0, "Yareli", "VB", 150, 3f, 1f, 0 },
                    { 47, 100, 1f, "D", 100, 1.5f, "", 150, 3f, "", 0, "Zephyr", "VB", 150, 3f, 1.15f, 0 },
                    { 48, 175, 1f, "V", 100, 1.5f, "", 150, 3f, "", 0, "Ash Prime", "BVV", 125, 3f, 1.2f, 0 },
                    { 49, 475, 1f, "V", 175, 1.5f, "", 175, 3f, "", 0, "Atlas Prime", "BDVV", 150, 3f, 1f, 0 },
                    { 50, 125, 1f, "V", 175, 1.5f, "", 100, 3f, "", 0, "Banshee Prime", "VVB", 100, 3f, 1.15f, 0 },
                    { 51, 475, 1f, "V", 200, 1.5f, "", 100, 3f, "", 0, "Chroma Prime", "BDVB", 100, 3f, 1f, 0 },
                    { 52, 150, 1f, "V", 150, 1.5f, "", 100, 3f, "", 0, "Ember Prime", "VD", 125, 3f, 1.1f, 0 },
                    { 53, 150, 1f, "B", 165, 1.5f, "", 125, 3f, "", 0, "Equinox Prime", "DDVV", 100, 3f, 1.15f, 0 },
                    { 43, 200, 1f, "B", 200, 1.5f, "", 100, 3f, "", 0, "Wisp", "VD", 75, 3f, 1.2f, 0 },
                    { 55, 300, 1f, "V", 150, 1.5f, "", 100, 3f, "", 0, "Excalibur Umbra", "VUUU", 100, 3f, 1f, 0 }
                });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 0f, null, 0f, 0f, 0, 8, "Acceltra", null, 0f, null, null });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 0f, null, 0f, 0f, 0, 14, 0, "Corinth", null, 0f, null, null });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 0f, null, 0f, 0f, 0, 10, 0, "Astilla", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[,]
                {
                    { 7, 0f, null, 0f, 0f, "", 0, 10, 0, "Amprex", null, 0f, null, null },
                    { 4, 0f, null, 0f, 0f, "", 0, 14, 0, "Astilla Prime", null, 0f, null, null },
                    { 29, 0f, null, 0f, 0f, "", 0, 10, 0, "Cernos Prime", null, 0f, null, null },
                    { 28, 0f, null, 0f, 0f, "", 0, 10, 0, "Cernos", null, 0f, null, null },
                    { 27, 0f, null, 0f, 0f, "", 0, 10, 0, "Cedo", null, 0f, null, null },
                    { 26, 0f, null, 0f, 0f, "", 0, 6, 0, "Carmine Penta", null, 0f, null, null },
                    { 25, 0f, null, 0f, 0f, "", 0, 10, 0, "Battacor", null, 0f, null, null },
                    { 24, 0f, null, 0f, 0f, "", 0, 11, 0, "Basmu", null, 0f, null, null },
                    { 23, 0f, null, 0f, 0f, "", 0, 11, 0, "Buzlok", null, 0f, null, null },
                    { 22, 0f, null, 0f, 0f, "", 0, 12, 0, "Burston Prime", null, 0f, null, null },
                    { 21, 0f, null, 0f, 0f, "", 0, 0, 0, "Burston", null, 0f, null, null },
                    { 20, 0f, null, 0f, 0f, "", 0, 13, 0, "Bubunico", null, 0f, null, null },
                    { 19, 0f, null, 0f, 0f, "", 0, 4, 0, "Braton Vandal", null, 0f, null, null },
                    { 18, 0f, null, 0f, 0f, "", 0, 8, 0, "Braton Prime", null, 0f, null, null },
                    { 17, 0f, null, 0f, 0f, "", 0, 0, 0, "Braton", null, 0f, null, null },
                    { 16, 0f, null, 0f, 0f, "", 0, 13, 0, "Boltor Prime", null, 0f, null, null },
                    { 15, 0f, null, 0f, 0f, "", 0, 2, 0, "Boltor", null, 0f, null, null },
                    { 14, 0f, null, 0f, 0f, "", 0, 11, 0, "Boar Prime", null, 0f, null, null },
                    { 13, 0f, null, 0f, 0f, "", 0, 2, 0, "Boar", null, 0f, null, null },
                    { 12, 0f, null, 0f, 0f, "", 0, 10, 0, "Baza Prime", null, 0f, null, null },
                    { 11, 0f, null, 0f, 0f, "", 0, 7, 0, "Baza", null, 0f, null, null },
                    { 10, 0f, null, 0f, 0f, "", 0, 0, 0, "Artemis Bow", null, 0f, null, null },
                    { 9, 0f, null, 0f, 0f, "", 0, 7, 0, "Argonak", null, 0f, null, null },
                    { 8, 0f, null, 0f, 0f, "", 0, 10, 0, "Arca Plasmor", null, 0f, null, null },
                    { 5, 0f, null, 0f, 0f, "", 0, 7, 0, "Attica", null, 0f, null, null },
                    { 6, 0f, null, 0f, 0f, "", 0, 10, 0, "Ambassador", null, 0f, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 25f, "Arm Cannon", 0.7f, 3.83f, 27, 0, "Bubunico", "Projectile", 16.875f, "Auto", "Arm Cannon" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 23.5f, "Rifle", 0.6f, 12f, 48, 8, 96, "Acceltra", "Projectile", 2f, "Auto", "Rifle" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Accuracy", "AmmoType", "Disposition", "FireRate", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 9.1f, "Shotgun", 0.9f, 1.42f, 20, 14, 120, "Corinth", "Hit Scan", 3f, "Semi-Auto", "Shotgun" });
        }
    }
}
