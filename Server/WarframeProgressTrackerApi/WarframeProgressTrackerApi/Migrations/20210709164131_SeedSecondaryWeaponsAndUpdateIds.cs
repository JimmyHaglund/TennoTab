using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class SeedSecondaryWeaponsAndUpdateIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 8, "Acceltra" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 14, "Corinth" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Astilla" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 14, "Astilla Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 7, "Attica" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Ambassador");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Amprex");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Arca Plasmor" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 7, "Argonak" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 0, "Artemis Bow" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 7, "Baza" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Baza Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 2, "Boar" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 11, "Boar Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 2, "Boltor" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 13, "Boltor Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 0, "Braton" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 8, "Braton Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 4, "Braton Vandal" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 13, "Bubunico" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 0, "Burston" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 12, "Burston Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Buzlok");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 11, "Basmu" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Battacor" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 6, "Carmine Penta" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Cedo");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Cernos");

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[,]
                {
                    { 114, 0f, null, 0f, 0f, "", 0, 7, 0, "Sobek", null, 0f, null, null },
                    { 89, 0f, null, 0f, 0f, "", 0, 3, 0, "Paris", null, 0f, null, null },
                    { 90, 0f, null, 0f, 0f, "", 0, 8, 0, "Paris Prime", null, 0f, null, null },
                    { 91, 0f, null, 0f, 0f, "", 0, 6, 0, "Penta", null, 0f, null, null },
                    { 92, 0f, null, 0f, 0f, "", 0, 11, 0, "Phage", null, 0f, null, null },
                    { 93, 0f, null, 0f, 0f, "", 0, 9, 0, "Phantasma", null, 0f, null, null },
                    { 94, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Gorgon", null, 0f, null, null },
                    { 95, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Grakata", null, 0f, null, null },
                    { 96, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Grinlok", null, 0f, null, null },
                    { 97, 0f, null, 0f, 0f, "", 0, 4, 0, "Prisma Tetra", null, 0f, null, null },
                    { 98, 0f, null, 0f, 0f, "", 0, 15, 0, "Proboscis Cernos", null, 0f, null, null },
                    { 99, 0f, null, 0f, 0f, "", 0, 4, 0, "Quanta", null, 0f, null, null },
                    { 100, 0f, null, 0f, 0f, "", 0, 10, 0, "Quanta Vandal", null, 0f, null, null },
                    { 101, 0f, null, 0f, 0f, "", 0, 10, 0, "Quartakk", null, 0f, null, null },
                    { 102, 0f, null, 0f, 0f, "", 0, 12, 0, "Quellor", null, 0f, null, null },
                    { 103, 0f, null, 0f, 0f, "", 0, 12, 0, "Rakta Cernos", null, 0f, null, null },
                    { 104, 0f, null, 0f, 0f, "", 0, 6, 0, "Rubico", null, 0f, null, null },
                    { 105, 0f, null, 0f, 0f, "", 0, 12, 0, "Rubico Prime", null, 0f, null, null },
                    { 106, 0f, null, 0f, 0f, "", 0, 12, 0, "Sancti Tigris", null, 0f, null, null },
                    { 107, 0f, null, 0f, 0f, "", 0, 6, 0, "Scourge", null, 0f, null, null },
                    { 108, 0f, null, 0f, 0f, "", 0, 12, 0, "Secura Penta", null, 0f, null, null },
                    { 109, 0f, null, 0f, 0f, "", 0, 13, 0, "Shedu", null, 0f, null, null },
                    { 110, 0f, null, 0f, 0f, "", 0, 5, 0, "Simulor", null, 0f, null, null },
                    { 111, 0f, null, 0f, 0f, "", 0, 0, 0, "Snipetron", null, 0f, null, null },
                    { 112, 0f, null, 0f, 0f, "", 0, 5, 0, "Snipetron Vandal", null, 0f, null, null },
                    { 113, 0f, null, 0f, 0f, "", 0, 0, 0, "Soaktron", null, 0f, null, null },
                    { 88, 0f, null, 0f, 0f, "", 0, 7, 0, "Paracyst", null, 0f, null, null },
                    { 87, 0f, null, 0f, 0f, "", 0, 14, 0, "Panthera Prime", null, 0f, null, null },
                    { 30, 0f, null, 0f, 0f, "", 0, 10, 0, "Cernos Prime", null, 0f, null, null },
                    { 85, 0f, null, 0f, 0f, "", 0, 14, 0, "Opticor Vandal", null, 0f, null, null },
                    { 33, 0f, null, 0f, 0f, "", 0, 10, 0, "Daikyu", null, 0f, null, null },
                    { 34, 0f, null, 0f, 0f, "", 0, 4, 0, "Dera", null, 0f, null, null },
                    { 35, 0f, null, 0f, 0f, "", 0, 7, 0, "Dera Vandal", null, 0f, null, null },
                    { 36, 0f, null, 0f, 0f, "", 0, 7, 0, "Dex Sybaris", null, 0f, null, null },
                    { 37, 0f, null, 0f, 0f, "", 0, 5, 0, "Drakgoon", null, 0f, null, null },
                    { 38, 0f, null, 0f, 0f, "", 0, 5, 0, "Dread", null, 0f, null, null },
                    { 39, 0f, null, 0f, 0f, "", 0, 8, 0, "Exergis", null, 0f, null, null },
                    { 40, 0f, null, 0f, 0f, "", 0, 14, 0, "Ferrox", null, 0f, null, null },
                    { 41, 0f, null, 0f, 0f, "", 0, 6, 0, "Flux Rifle", null, 0f, null, null },
                    { 42, 0f, null, 0f, 0f, "", 0, 8, 0, "Fulmin", null, 0f, null, null },
                    { 43, 0f, null, 0f, 0f, "", 0, 8, 0, "Gaxion", null, 0f, null, null },
                    { 44, 0f, null, 0f, 0f, "", 0, 12, 0, "Glaxion Vandal", null, 0f, null, null },
                    { 45, 0f, null, 0f, 0f, "", 0, 3, 0, "Gorgon", null, 0f, null, null },
                    { 46, 0f, null, 0f, 0f, "", 0, 7, 0, "Gorgon Wraith", null, 0f, null, null },
                    { 47, 0f, null, 0f, 0f, "", 0, 5, 0, "Grakata", null, 0f, null, null },
                    { 48, 0f, null, 0f, 0f, "", 0, 7, 0, "Grinlok", null, 0f, null, null },
                    { 49, 0f, null, 0f, 0f, "", 0, 7, 0, "Harpak", null, 0f, null, null },
                    { 51, 0f, null, 0f, 0f, "", 0, 7, 0, "Hema", null, 0f, null, null },
                    { 52, 0f, null, 0f, 0f, "", 0, 0, 0, "Hind", null, 0f, null, null },
                    { 53, 0f, null, 0f, 0f, "", 0, 5, 0, "Ignis", null, 0f, null, null },
                    { 54, 0f, null, 0f, 0f, "", 0, 9, 0, "Ignis Wraith", null, 0f, null, null },
                    { 55, 0f, null, 0f, 0f, "", 0, 7, 0, "Javlok", null, 0f, null, null },
                    { 57, 0f, null, 0f, 0f, "", 0, 7, 0, "Karak Wraith", null, 0f, null, null },
                    { 56, 0f, null, 0f, 0f, "", 0, 1, 0, "Karak", null, 0f, null, null },
                    { 86, 0f, null, 0f, 0f, "", 0, 7, 0, "Pathera", null, 0f, null, null },
                    { 32, 0f, null, 0f, 0f, "", 0, 14, 0, "Corinth Prime", null, 0f, null, null },
                    { 31, 0f, null, 0f, 0f, "", 0, 7, 0, "Convectrix", null, 0f, null, null },
                    { 50, 0f, null, 0f, 0f, "", 0, 4, 0, "Hek", null, 0f, null, null },
                    { 59, 0f, null, 0f, 0f, "", 0, 8, 0, "Komorex", null, 0f, null, null },
                    { 84, 0f, null, 0f, 0f, "", 0, 14, 0, "Opticor", null, 0f, null, null },
                    { 58, 0f, null, 0f, 0f, "", 0, 5, 0, "Kohm", null, 0f, null, null },
                    { 83, 0f, null, 0f, 0f, "", 0, 9, 0, "Ogris", null, 0f, null, null },
                    { 82, 0f, null, 0f, 0f, "", 0, 9, 0, "Nagantaka", null, 0f, null, null },
                    { 81, 0f, null, 0f, 0f, "", 0, 2, 0, "Mutalist Quanta", null, 0f, null, null },
                    { 79, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Strun", null, 0f, null, null },
                    { 78, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Paris", null, 0f, null, null },
                    { 77, 0f, null, 0f, 0f, "", 0, 0, 0, "Mk1-Braton", null, 0f, null, null },
                    { 76, 0f, null, 0f, 0f, "", 0, 6, 0, "Miter", null, 0f, null, null },
                    { 75, 0f, null, 0f, 0f, "", 0, 8, 0, "Lenz", null, 0f, null, null },
                    { 74, 0f, null, 0f, 0f, "", 0, 7, 0, "Latron Wraith", null, 0f, null, null },
                    { 73, 0f, null, 0f, 0f, "", 0, 10, 0, "Latron Prime", null, 0f, null, null },
                    { 80, 0f, null, 0f, 0f, "", 0, 7, 0, "Mutalist Cernos", null, 0f, null, null },
                    { 71, 0f, null, 0f, 0f, "", 0, 10, 0, "Lanka", null, 0f, null, null },
                    { 72, 0f, null, 0f, 0f, "", 0, 0, 0, "Latron", null, 0f, null, null },
                    { 60, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Bramma", null, 0f, null, null },
                    { 62, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Drakgoon", null, 0f, null, null },
                    { 63, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Hek", null, 0f, null, null },
                    { 65, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Karak", null, 0f, null, null },
                    { 64, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Hind", null, 0f, null, null },
                    { 67, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Ogris", null, 0f, null, null },
                    { 68, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Quartakk", null, 0f, null, null },
                    { 69, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Tonkor", null, 0f, null, null },
                    { 70, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Zarr", null, 0f, null, null },
                    { 66, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Kohm", null, 0f, null, null },
                    { 61, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Cakkhurr", null, 0f, null, null }
                });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[,]
                {
                    { 199, 0f, null, 0f, 0f, "", 0, 6, 0, "Rakta Ballistica", null, 0f, null, null },
                    { 194, 0f, null, 0f, 0f, "", 0, 8, 0, "Prisma Angstrum", null, 0f, null, null },
                    { 200, 0f, null, 0f, 0f, "", 0, 0, 0, "Regulators", null, 0f, null, null },
                    { 198, 0f, null, 0f, 0f, "", 0, 9, 0, "Quatz", null, 0f, null, null },
                    { 197, 0f, null, 0f, 0f, "", 0, 13, 0, "Pyrana Prime", null, 0f, null, null },
                    { 196, 0f, null, 0f, 0f, "", 0, 12, 0, "Pyrana", null, 0f, null, null },
                    { 195, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Twin Gremlins", null, 0f, null, null },
                    { 189, 0f, null, 0f, 0f, "", 0, 8, 0, "Ocucor", null, 0f, null, null },
                    { 192, 0f, null, 0f, 0f, "", 0, 6, 0, "Plinx", null, 0f, null, null },
                    { 191, 0f, null, 0f, 0f, "", 0, 14, 0, "Pandero Prime", null, 0f, null, null },
                    { 190, 0f, null, 0f, 0f, "", 0, 8, 0, "Pandero", null, 0f, null, null },
                    { 188, 0f, null, 0f, 0f, "", 0, 4, 0, "Nukor", null, 0f, null, null },
                    { 187, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Kunai", null, 0f, null, null },
                    { 186, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Furis", null, 0f, null, null },
                    { 201, 0f, null, 0f, 0f, "", 0, 10, 0, "Sancti Castanas", null, 0f, null, null },
                    { 185, 0f, null, 0f, 0f, "", 0, 7, 0, "Marelok", null, 0f, null, null },
                    { 193, 0f, null, 0f, 0f, "", 0, 9, 0, "Pox", null, 0f, null, null },
                    { 202, 0f, null, 0f, 0f, "", 0, 10, 0, "Secura Dual Cestra", null, 0f, null, null },
                    { 215, 0f, null, 0f, 0f, "", 0, 7, 0, "Synoid Gammacor", null, 0f, null, null },
                    { 204, 0f, null, 0f, 0f, "", 0, 14, 0, "Sepulcrum", null, 0f, null, null },
                    { 184, 0f, null, 0f, 0f, "", 0, 9, 0, "Mara Detron", null, 0f, null, null },
                    { 222, 0f, null, 0f, 0f, "", 0, 9, 0, "Twin Grakatas", null, 0f, null, null },
                    { 221, 0f, null, 0f, 0f, "", 0, 14, 0, "Tenet Spirex", null, 0f, null, null },
                    { 220, 0f, null, 0f, 0f, "", 0, 16, 0, "Tenet Diplos", null, 0f, null, null },
                    { 219, 0f, null, 0f, 0f, "", 0, 16, 0, "Tenet Detron", null, 0f, null, null },
                    { 218, 0f, null, 0f, 0f, "", 0, 14, 0, "Tenet Cycron", null, 0f, null, null },
                    { 217, 0f, null, 0f, 0f, "", 0, 11, 0, "Telos Akbolto", null, 0f, null, null },
                    { 216, 0f, null, 0f, 0f, "", 0, 8, 0, "Talons", null, 0f, null, null },
                    { 203, 0f, null, 0f, 0f, "", 0, 0, 0, "Seer", null, 0f, null, null },
                    { 214, 0f, null, 0f, 0f, "", 0, 2, 0, "Stug", null, 0f, null, null },
                    { 212, 0f, null, 0f, 0f, "", 0, 10, 0, "Staticor", null, 0f, null, null },
                    { 211, 0f, null, 0f, 0f, "", 0, 10, 0, "Spira Prime", null, 0f, null, null },
                    { 210, 0f, null, 0f, 0f, "", 0, 8, 0, "Spira", null, 0f, null, null },
                    { 209, 0f, null, 0f, 0f, "", 0, 10, 0, "Spectra Vandal", null, 0f, null, null },
                    { 208, 0f, null, 0f, 0f, "", 0, 4, 0, "Spectra", null, 0f, null, null },
                    { 207, 0f, null, 0f, 0f, "", 0, 2, 0, "Sonicor", null, 0f, null, null },
                    { 206, 0f, null, 0f, 0f, "", 0, 14, 0, "Sicarus Prime", null, 0f, null, null },
                    { 205, 0f, null, 0f, 0f, "", 0, 3, 0, "Sicarus", null, 0f, null, null },
                    { 213, 0f, null, 0f, 0f, "", 0, 7, 0, "Stubba", null, 0f, null, null },
                    { 183, 0f, null, 0f, 0f, "", 0, 10, 0, "Magnus", null, 0f, null, null },
                    { 168, 0f, null, 0f, 0f, "", 0, 5, 0, "Kohomak", null, 0f, null, null },
                    { 181, 0f, null, 0f, 0f, "", 0, 3, 0, "Lex", null, 0f, null, null },
                    { 145, 0f, null, 0f, 0f, "", 0, 0, 0, "Bronco", null, 0f, null, null },
                    { 144, 0f, null, 0f, 0f, "", 0, 6, 0, "Brakk", null, 0f, null, null },
                    { 143, 0f, null, 0f, 0f, "", 0, 7, 0, "Bolto", null, 0f, null, null },
                    { 142, 0f, null, 0f, 0f, "", 0, 14, 0, "Ballistica Prime", null, 0f, null, null },
                    { 141, 0f, null, 0f, 0f, "", 0, 2, 0, "Ballistica", null, 0f, null, null },
                    { 139, 0f, null, 0f, 0f, "", 0, 6, 0, "Azima", null, 0f, null, null },
                    { 138, 0f, null, 0f, 0f, "", 0, 5, 0, "Atomos", null, 0f, null, null },
                    { 137, 0f, null, 0f, 0f, "", 0, 10, 0, "Athodai", null, 0f, null, null },
                    { 136, 0f, null, 0f, 0f, "", 0, 10, 0, "Arca Scisco", null, 0f, null, null },
                    { 135, 0f, null, 0f, 0f, "", 0, 4, 0, "Angstrum", null, 0f, null, null },
                    { 134, 0f, null, 0f, 0f, "", 0, 4, 0, "Akszani", null, 0f, null, null },
                    { 133, 0f, null, 0f, 0f, "", 0, 12, 0, "Akvasto Prime", null, 0f, null, null },
                    { 132, 0f, null, 0f, 0f, "", 0, 8, 0, "Akvasto", null, 0f, null, null },
                    { 131, 0f, null, 0f, 0f, "", 0, 10, 0, "Akstiletto Prime", null, 0f, null, null },
                    { 146, 0f, null, 0f, 0f, "", 0, 4, 0, "Bronco Prime", null, 0f, null, null },
                    { 130, 0f, null, 0f, 0f, "", 0, 8, 0, "Akstiletto", null, 0f, null, null },
                    { 128, 0f, null, 0f, 0f, "", 0, 9, 0, "Aksomati", null, 0f, null, null }
                });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[,]
                {
                    { 127, 0f, null, 0f, 0f, "", 0, 12, 0, "Akmagnus", null, 0f, null, null },
                    { 126, 0f, null, 0f, 0f, "", 0, 15, 0, "Aklex Prime", null, 0f, null, null },
                    { 125, 0f, null, 0f, 0f, "", 0, 4, 0, "Aklex", null, 0f, null, null },
                    { 124, 0f, null, 0f, 0f, "", 0, 3, 0, "Aklato", null, 0f, null, null },
                    { 123, 0f, null, 0f, 0f, "", 0, 12, 0, "Akjagara Prime", null, 0f, null, null },
                    { 122, 0f, null, 0f, 0f, "", 0, 8, 0, "Akjagara", null, 0f, null, null },
                    { 121, 0f, null, 0f, 0f, "", 0, 10, 0, "Akbronco Prime", null, 0f, null, null },
                    { 120, 0f, null, 0f, 0f, "", 0, 2, 0, "Akbronco", null, 0f, null, null },
                    { 119, 0f, null, 0f, 0f, "", 0, 13, 0, "Akbolto Prime", null, 0f, null, null },
                    { 118, 0f, null, 0f, 0f, "", 0, 9, 0, "Akbolto", null, 0f, null, null },
                    { 117, 0f, null, 0f, 0f, "", 0, 8, 0, "Akarius", null, 0f, null, null },
                    { 116, 0f, null, 0f, 0f, "", 0, 4, 0, "Afuris", null, 0f, null, null },
                    { 115, 0f, null, 0f, 0f, "", 0, 7, 0, "Acrid", null, 0f, null, null },
                    { 129, 0f, null, 0f, 0f, "", 0, 12, 0, "Aksomati Prime", null, 0f, null, null },
                    { 182, 0f, null, 0f, 0f, "", 0, 8, 0, "Lex Prime", null, 0f, null, null },
                    { 147, 0f, null, 0f, 0f, "", 0, 3, 0, "Castanas", null, 0f, null, null },
                    { 149, 0f, null, 0f, 0f, "", 0, 4, 0, "Cestra", null, 0f, null, null },
                    { 180, 0f, null, 0f, 0f, "", 0, 7, 0, "Lato Vandal", null, 0f, null, null },
                    { 179, 0f, null, 0f, 0f, "", 0, 14, 0, "Lato Prime", null, 0f, null, null },
                    { 178, 0f, null, 0f, 0f, "", 0, 0, 0, "Lato", null, 0f, null, null },
                    { 177, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Twin Stubbas", null, 0f, null, null },
                    { 176, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Seer", null, 0f, null, null },
                    { 175, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Nukor", null, 0f, null, null },
                    { 174, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Kraken", null, 0f, null, null },
                    { 173, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Brakk", null, 0f, null, null },
                    { 172, 0f, null, 0f, 0f, "", 0, 2, 0, "Kunai", null, 0f, null, null },
                    { 171, 0f, null, 0f, 0f, "", 0, 5, 0, "Kulstar", null, 0f, null, null },
                    { 170, 0f, null, 0f, 0f, "", 0, 0, 0, "Kraken", null, 0f, null, null },
                    { 169, 0f, null, 0f, 0f, "", 0, 8, 0, "Kompressa", null, 0f, null, null },
                    { 167, 0f, null, 0f, 0f, "", 0, 10, 0, "Knell", null, 0f, null, null },
                    { 166, 0f, null, 0f, 0f, "", 0, 7, 0, "Hystrix", null, 0f, null, null },
                    { 148, 0f, null, 0f, 0f, "", 0, 11, 0, "Catabolyst", null, 0f, null, null },
                    { 165, 0f, null, 0f, 0f, "", 0, 4, 0, "Hikou Prime", null, 0f, null, null },
                    { 163, 0f, null, 0f, 0f, "", 0, 2, 0, "Gammacor", null, 0f, null, null },
                    { 162, 0f, null, 0f, 0f, "", 0, 7, 0, "Fusilai", null, 0f, null, null },
                    { 161, 0f, null, 0f, 0f, "", 0, 2, 0, "Furis", null, 0f, null, null },
                    { 160, 0f, null, 0f, 0f, "", 0, 14, 0, "Euphona Prime", null, 0f, null, null },
                    { 159, 0f, null, 0f, 0f, "", 0, 8, 0, "Epitaph", null, 0f, null, null },
                    { 158, 0f, null, 0f, 0f, "", 0, 9, 0, "Embolist", null, 0f, null, null },
                    { 157, 0f, null, 0f, 0f, "", 0, 11, 0, "Dual Toxocyst", null, 0f, null, null },
                    { 156, 0f, null, 0f, 0f, "", 0, 7, 0, "Dual Cestra", null, 0f, null, null },
                    { 155, 0f, null, 0f, 0f, "", 0, 0, 0, "Dex Pixia", null, 0f, null, null },
                    { 154, 0f, null, 0f, 0f, "", 0, 10, 0, "Dex Furis", null, 0f, null, null },
                    { 153, 0f, null, 0f, 0f, "", 0, 6, 0, "Detron", null, 0f, null, null },
                    { 152, 0f, null, 0f, 0f, "", 0, 4, 0, "Despair", null, 0f, null, null },
                    { 151, 0f, null, 0f, 0f, "", 0, 8, 0, "Cycron", null, 0f, null, null },
                    { 150, 0f, null, 0f, 0f, "", 0, 8, 0, "Cyanex", null, 0f, null, null },
                    { 164, 0f, null, 0f, 0f, "", 0, 2, 0, "Hikou", null, 0f, null, null },
                    { 140, 0f, null, 0f, 0f, "", 0, 0, 0, "Balefire Charger", null, 0f, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 14, "Corinth" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Astilla" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 14, "Astilla Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 7, "Attica" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Ambassador" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Amprex");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Arca Plasmor");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 7, "Argonak" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 0, "Artemis Bow" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 7, "Baza" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Baza Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 2, "Boar" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 11, "Boar Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 2, "Boltor" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 13, "Boltor Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 0, "Braton" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 8, "Braton Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 4, "Braton Vandal" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 13, "Bubunico" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 0, "Burston" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 12, "Burston Prime" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 11, "Buzlok" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Basmu");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Battacor" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 6, "Carmine Penta" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MasteryRankRequired", "Name" },
                values: new object[] { 10, "Cedo" });

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Cernos");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Cernos Prime");

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 1, 0f, null, 0f, 0f, "", 0, 8, 0, "Acceltra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[,]
                {
                    { 2, 16f, "Pistol", 1.25f, 1.08f, "", 6, 3, 210, "Lex", "Hit Scan", 2.35f, "Semi-Auto", "Pistol" },
                    { 1, 33.33f, "Pistol", 1.52f, 8.33f, "", 60, 4, 420, "Cestra", "Projectile", 2f, "Auto", "Pistol" },
                    { 3, 5f, "Shotgun Sidearm", 0.95f, 4.17f, "", 10, 12, 210, "Pyrana", "Hit Scan", 2f, "Auto", "Shotgun Sidearm" }
                });
        }
    }
}
