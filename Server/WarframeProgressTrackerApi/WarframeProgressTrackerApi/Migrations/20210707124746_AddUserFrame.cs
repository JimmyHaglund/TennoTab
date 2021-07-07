using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddUserFrame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HowToGet",
                table: "SecondaryWeapons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowToGet",
                table: "PrimaryWeapons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowToGet",
                table: "MeleeWeapons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowToGet",
                table: "Frames",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserFrames",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FrameId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFrames", x => new { x.UserId, x.FrameId });
                });

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 1,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 2,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 3,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 4,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 5,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 6,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 7,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 8,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 9,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 10,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 11,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 12,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 13,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 14,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 15,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 16,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 17,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 18,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 19,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 20,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 21,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 22,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 23,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 24,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 25,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 26,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 27,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 28,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 29,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "Frames",
                keyColumn: "Id",
                keyValue: 30,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "MeleeWeapons",
                keyColumn: "Id",
                keyValue: 1,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "MeleeWeapons",
                keyColumn: "Id",
                keyValue: 2,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "MeleeWeapons",
                keyColumn: "Id",
                keyValue: 3,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 1,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 2,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "PrimaryWeapons",
                keyColumn: "Id",
                keyValue: 3,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 1,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 2,
                column: "HowToGet",
                value: "");

            migrationBuilder.UpdateData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 3,
                column: "HowToGet",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFrames");

            migrationBuilder.DropColumn(
                name: "HowToGet",
                table: "SecondaryWeapons");

            migrationBuilder.DropColumn(
                name: "HowToGet",
                table: "PrimaryWeapons");

            migrationBuilder.DropColumn(
                name: "HowToGet",
                table: "MeleeWeapons");

            migrationBuilder.DropColumn(
                name: "HowToGet",
                table: "Frames");
        }
    }
}
