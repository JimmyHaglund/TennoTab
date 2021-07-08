using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class FixWrongDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMeleeWeapon",
                table: "UserMeleeWeapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeleeWeapon",
                table: "MeleeWeapon");

            migrationBuilder.RenameTable(
                name: "UserMeleeWeapon",
                newName: "UserMeleeWeapons");

            migrationBuilder.RenameTable(
                name: "MeleeWeapon",
                newName: "MeleeWeapons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMeleeWeapons",
                table: "UserMeleeWeapons",
                columns: new[] { "UserId", "WeaponId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeleeWeapons",
                table: "MeleeWeapons",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMeleeWeapons",
                table: "UserMeleeWeapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeleeWeapons",
                table: "MeleeWeapons");

            migrationBuilder.RenameTable(
                name: "UserMeleeWeapons",
                newName: "UserMeleeWeapon");

            migrationBuilder.RenameTable(
                name: "MeleeWeapons",
                newName: "MeleeWeapon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMeleeWeapon",
                table: "UserMeleeWeapon",
                columns: new[] { "UserId", "WeaponId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeleeWeapon",
                table: "MeleeWeapon",
                column: "Id");
        }
    }
}
