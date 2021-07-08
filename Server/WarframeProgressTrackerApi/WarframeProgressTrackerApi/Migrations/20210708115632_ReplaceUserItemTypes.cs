using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class ReplaceUserItemTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "UserSecondaryWeapons");

            migrationBuilder.CreateTable(
                name: "UserItem",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItem", x => new { x.UserId, x.ItemId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserItem");

            migrationBuilder.CreateTable(
                name: "UserArchGuns",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchGuns", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserArchMeleeWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchMeleeWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserArchwings",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArchwingId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchwings", x => new { x.UserId, x.ArchwingId });
                });

            migrationBuilder.CreateTable(
                name: "UserFrames",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FrameId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFrames", x => new { x.UserId, x.FrameId });
                });

            migrationBuilder.CreateTable(
                name: "UserMeleeWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMeleeWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserPets",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPets", x => new { x.UserId, x.PetId });
                });

            migrationBuilder.CreateTable(
                name: "UserPrimaryWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPrimaryWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserRoboWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoboWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserSecondaryWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    MasteryRank = table.Column<int>(type: "int", nullable: false),
                    Obtained = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecondaryWeapons", x => new { x.UserId, x.WeaponId });
                });
        }
    }
}
