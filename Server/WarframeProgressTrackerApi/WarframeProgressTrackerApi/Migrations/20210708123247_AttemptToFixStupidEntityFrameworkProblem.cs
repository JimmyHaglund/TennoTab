using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AttemptToFixStupidEntityFrameworkProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserItem",
                table: "UserItem");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UserItem");

            migrationBuilder.RenameTable(
                name: "UserItem",
                newName: "UserSecondaryWeapons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSecondaryWeapons",
                table: "UserSecondaryWeapons",
                columns: new[] { "UserId", "ItemId" });

            migrationBuilder.CreateTable(
                name: "UserArchGuns",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchGuns", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserArchMeleeWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchMeleeWeapons", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserArchwings",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchwings", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserFrames",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFrames", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserMeleeWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMeleeWeapons", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserPets",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPets", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserPrimaryWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPrimaryWeapons", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserRoboWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoboWeapons", x => new { x.UserId, x.ItemId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserArchGuns");

            migrationBuilder.DropTable(
                name: "UserArchMeleeWeapons");

            migrationBuilder.DropTable(
                name: "UserArchwings");

            migrationBuilder.DropTable(
                name: "UserFrames");

            migrationBuilder.DropTable(
                name: "UserMeleeWeapons");

            migrationBuilder.DropTable(
                name: "UserPets");

            migrationBuilder.DropTable(
                name: "UserPrimaryWeapons");

            migrationBuilder.DropTable(
                name: "UserRoboWeapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSecondaryWeapons",
                table: "UserSecondaryWeapons");

            migrationBuilder.RenameTable(
                name: "UserSecondaryWeapons",
                newName: "UserItem");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UserItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserItem",
                table: "UserItem",
                columns: new[] { "UserId", "ItemId" });
        }
    }
}
