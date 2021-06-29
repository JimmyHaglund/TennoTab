using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddSeedFrames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ArmorMaxFactor",
                table: "Frames",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "EnergyMaxFactor",
                table: "Frames",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "HealthMaxFactor",
                table: "Frames",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "MasteryRankRequired",
                table: "Frames",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ShieldMaxFactor",
                table: "Frames",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Armor", "ArmorMaxFactor", "AuraPolarity", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 225, 1f, "", 1.5f, "", 100, 3f, "DV", 100, 3f });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[,]
                {
                    { 29, 100, 1f, "B", 150, 1.5f, "", 100, 3f, 0, "Nova", "VV", 75, 3f, 1.2f, 0 },
                    { 28, 300, 1.5f, "V", 100, 1.5f, "", 150, 3f, 0, "Nidus", "VD", 0, 3f, 1f, 0 },
                    { 27, 190, 1f, "B", 150, 1.5f, "", 125, 3f, 0, "Nezha", "DV", 50, 3f, 1.15f, 0 },
                    { 26, 100, 1f, "", 100, 1.5f, "", 100, 3f, 0, "Nekros", "BV", 90, 3f, 1.1f, 0 },
                    { 25, 100, 1f, "B", 150, 1.5f, "", 80, 3f, 0, "Mirage", "DV", 80, 3f, 1.2f, 0 },
                    { 24, 100, 1f, "V", 100, 1.5f, "", 125, 3f, 0, "Mesa", "BB", 75, 3f, 1.1f, 0 },
                    { 23, 100, 1f, "V", 125, 1.5f, "", 75, 3f, 0, "Mag", "BB", 150, 3f, 1.25f, 0 },
                    { 22, 100, 1f, "B", 100, 1.5f, "", 75, 3f, 0, "Loki", "DV", 75, 3f, 1.25f, 0 },
                    { 21, 100, 1f, "B", 150, 1.5f, "", 100, 3f, 0, "Limbo", "VV", 75, 3f, 1.15f, 0 },
                    { 20, 450, 1.5f, "B", 0, 1.5f, "", 200, 3f, 0, "Lavos", "DB", 100, 3f, 1.15f, 0 },
                    { 19, 275, 1f, "D", 125, 1.5f, "B", 125, 3f, 0, "Khora", "VB", 100, 3f, 1.05f, 0 },
                    { 18, 100, 1f, "B", 175, 1.5f, "", 75, 3f, 0, "Ivara", "DB", 100, 3f, 1.15f, 0 },
                    { 17, 225, 1f, "B", 100, 1.5f, "B", 550, 4f, 0, "Inaros", "DD", 0, 0f, 1f, 0 },
                    { 16, 225, 1f, "B", 125, 1.5f, "", 100, 3f, 0, "Hydroid", "VB", 125, 3f, 1.05f, 0 },
                    { 15, 100, 1f, "B", 0, 0f, "D", 75, 3f, 0, "Hildryn", "DD", 450, 3.5f, 1f, 0 },
                    { 14, 175, 1f, "B", 100, 1.5f, "", 100, 3f, 0, "Harrow", "DB", 150, 3f, 1f, 0 },
                    { 13, 350, 1f, "B", 150, 1.5f, "", 350, 3f, 0, "Grendel", "BDD", 25, 3f, 0.95f, 0 },
                    { 12, 175, 1f, "B", 150, 1.5f, "B", 100, 3f, 0, "Gauss", "VD", 150, 3f, 1.4f, 0 },
                    { 11, 300, 1f, "V", 120, 2.25f, "", 100, 3f, 0, "Garuda", "BD", 100, 3f, 1f, 0 },
                    { 10, 150, 1f, "D", 150, 1.5f, "", 100, 3f, 0, "Gara", "VV", 100, 3f, 1.15f, 0 },
                    { 9, 300, 1f, "D", 100, 1.5f, "", 100, 3f, 0, "Frost", "BD", 150, 3f, 0.9f, 0 },
                    { 8, 125, 1f, "B", 150, 1.5f, "", 100, 3f, 0, "Equinox", "DV", 100, 3f, 1.15f, 0 },
                    { 7, 125, 1f, "V", 150, 1.5f, "", 100, 3f, 0, "Ember", "BB", 100, 3f, 1.1f, 0 },
                    { 6, 350, 1f, "V", 150, 1.5f, "", 100, 3f, 0, "Chroma", "BV", 100, 3f, 1f, 0 },
                    { 5, 175, 1f, "B", 200, 1.5f, "B", 75, 3f, 0, "Baruuk", "DD", 100, 3f, 1.2f, 0 },
                    { 4, 100, 1f, "V", 150, 1.5f, "", 100, 3f, 0, "Banshee", "VV", 100, 3f, 1.1f, 0 },
                    { 3, 450, 1f, "V", 150, 1.5f, "", 100, 3f, 0, "Atlas", "BDV", 100, 3f, 0.9f, 0 },
                    { 30, 100, 1f, "B", 150, 1.5f, "", 100, 3f, 0, "Nyx", "VB", 100, 3f, 1.1f, 0 },
                    { 2, 100, 1f, "V", 100, 1.5f, "", 150, 3f, 0, "Ash", "VV", 100, 3f, 1.15f, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "ArmorMaxFactor",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "EnergyMaxFactor",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "HealthMaxFactor",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "MasteryRankRequired",
                table: "Frames");

            migrationBuilder.DropColumn(
                name: "ShieldMaxFactor",
                table: "Frames");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Armor", "AuraPolarity", "ExilusPolarity", "Health", "Polarities", "Shield" },
                values: new object[] { 100, "A", "E", 110, "UAF", 50 });
        }
    }
}
