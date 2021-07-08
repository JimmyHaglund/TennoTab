using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeleeWeapons",
                table: "MeleeWeapons");

            migrationBuilder.RenameTable(
                name: "MeleeWeapons",
                newName: "MeleeWeapon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeleeWeapon",
                table: "MeleeWeapon",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ArchGuns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MasteryRankRequired = table.Column<int>(nullable: false),
                    HowToGet = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_ArchGuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArchMeleeWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MasteryRankRequired = table.Column<int>(nullable: false),
                    HowToGet = table.Column<string>(nullable: true),
                    RangeMetres = table.Column<float>(nullable: false),
                    AttackSpeed = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchMeleeWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Archwings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HowToGet = table.Column<string>(nullable: true),
                    MasteryRankRequired = table.Column<int>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    HealthMaxFactor = table.Column<float>(nullable: false),
                    Shield = table.Column<int>(nullable: false),
                    ShieldMaxFactor = table.Column<float>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    ArmorMaxFactor = table.Column<float>(nullable: false),
                    Energy = table.Column<int>(nullable: false),
                    EnergyMaxFactor = table.Column<float>(nullable: false),
                    FlightSpeed = table.Column<float>(nullable: false),
                    Polarities = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archwings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    MasteryRankRequired = table.Column<int>(nullable: false),
                    HowToGet = table.Column<string>(nullable: true),
                    Health = table.Column<int>(nullable: false),
                    HealthMaxFactor = table.Column<float>(nullable: false),
                    Shield = table.Column<int>(nullable: false),
                    ShieldMaxFactor = table.Column<float>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    ArmorMaxFactor = table.Column<float>(nullable: false),
                    Polarities = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoboWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HowToGet = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_RoboWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserArchGuns",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchGuns", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserArchMeleeWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchMeleeWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserArchwings",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ArchwingId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArchwings", x => new { x.UserId, x.ArchwingId });
                });

            migrationBuilder.CreateTable(
                name: "UserMeleeWeapon",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMeleeWeapon", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserPets",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    PetId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPets", x => new { x.UserId, x.PetId });
                });

            migrationBuilder.CreateTable(
                name: "UserPrimaryWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPrimaryWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserRoboWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoboWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.CreateTable(
                name: "UserSecondaryWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecondaryWeapons", x => new { x.UserId, x.WeaponId });
                });

            migrationBuilder.InsertData(
                table: "Archwings",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Energy", "EnergyMaxFactor", "FlightSpeed", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[,]
                {
                    { 1, 200, 1f, 200, 1.8f, 1.1f, 400, 3f, "", 0, "Amesha", "BDV", 200, 3f },
                    { 2, 150, 1f, 125, 1.8f, 0.9f, 450, 3f, "", 0, "Elytron", "VV", 450, 3f },
                    { 3, 50, 1f, 200, 1.8f, 1.2f, 200, 3f, "", 0, "Itzal", "VDB", 200, 3f },
                    { 4, 100, 1f, 100, 1.8f, 1f, 300, 3f, "", 0, "Odonata", "VDB", 300, 3f },
                    { 5, 100, 1f, 100, 1.8f, 1.05f, 400, 3f, "", 0, "Odonata Prime", "VDBB", 400, 3f }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[,]
                {
                    { 19, 50, 1f, "Sentinel", 350, 1f, "", 0, "Shade", "SSSS", 50, 1f },
                    { 20, 75, 1f, "Sentinel", 350, 1f, "", 0, "Prisma Shade", "SSSSB", 100, 1f },
                    { 21, 50, 1f, "Sentinel", 200, 1f, "", 0, "Taxon", "", 100, 1f },
                    { 22, 50, 1f, "Sentinel", 200, 1f, "", 0, "Wyrm", "SSSS", 100, 1f },
                    { 23, 150, 1f, "Sentinel", 225, 1f, "", 0, "Wyrm Prime", "SSSS", 300, 1f },
                    { 24, 0, 1f, "MOA", 0, 3f, "", 0, "Para", "", 0, 3f },
                    { 25, 0, 1f, "MOA", 0, 3f, "", 0, "Lambeo", "", 0, 3f },
                    { 27, 0, 1f, "MOA", 0, 3f, "", 0, "Nychus", "", 0, 3f },
                    { 18, 50, 1f, "Sentinel", 200, 1f, "", 0, "Oxylus", "", 100, 1f },
                    { 28, 50, 1f, "Kavat", 40, 3f, "", 0, "Adarza", "SS", 70, 3f },
                    { 29, 50, 1f, "Kavat", 50, 3f, "", 0, "Smeeta", "SS", 60, 3f },
                    { 30, 50, 1f, "Kavat", 80, 3f, "", 0, "Vasca", "SS", 70, 3f },
                    { 31, 350, 1f, "Kavat", 300, 3f, "Khora's special companion", 0, "Venari", "SVDB", 0, 3f },
                    { 32, 50, 1f, "Kavat", 90, 3f, "", 0, "Sly Vulpaphyla", "S", 95, 3f },
                    { 26, 0, 1f, "MOA", 0, 3f, "", 0, "Oloro", "", 0, 3f },
                    { 17, 50, 1f, "Sentinel", 200, 1f, "", 0, "Nautilus", "SSSSD", 100, 1f },
                    { 35, 50, 1f, "Sentinel", 200, 1f, "", 0, "Djinn", "SSSSB", 100, 1f },
                    { 15, 50, 1f, "Sentinel", 200, 1f, "", 0, "Helios", "SSSSD", 100, 1f },
                    { 1, 50, 1f, "Kubrow", 75, 3f, "", 0, "Huras", "SSV", 125, 3f },
                    { 2, 50, 1f, "Kubrow", 100, 3f, "", 0, "Raksa", "SSD", 105, 3f },
                    { 3, 50, 1f, "Kubrow", 125, 3f, "", 0, "Sahasa", "SSB", 75, 3f },
                    { 4, 50, 1f, "Kubrow", 110, 3f, "", 0, "Sunika", "SSV", 90, 3f },
                    { 5, 50, 1f, "Kubrow", 125, 3f, "", 0, "Chesa", "SSD", 75, 3f },
                    { 6, 50, 1f, "Kubrow", 95, 3f, "", 0, "Helminth Charger", "SSV", 85, 3f },
                    { 7, 50, 1f, "Kubrow", 95, 3f, "", 0, "Vizier Predasite", "S", 90, 3f },
                    { 8, 50, 1f, "Kubrow", 95, 3f, "", 0, "Pharaoh Predasite", "S", 90, 3f },
                    { 9, 50, 1f, "Kubrow", 95, 3f, "", 0, "Medjay Predasite", "S", 90, 3f },
                    { 10, 50, 1f, "Sentinel", 200, 1f, "", 0, "Carrier", "SSSSD", 100, 1f },
                    { 11, 150, 1f, "Sentinel", 400, 1f, "", 0, "Carrier Prime", "SSSSDV", 100, 1f },
                    { 12, 50, 1f, "Sentinel", 200, 1f, "", 0, "Dethcube", "SSSS", 100, 1f },
                    { 13, 150, 1f, "Sentinel", 300, 1f, "", 0, "Dethcube Prime", "SSSSD", 100, 1f },
                    { 14, 50, 1f, "Sentinel", 350, 1f, "", 0, "Diriga", "SSSS", 50, 1f },
                    { 33, 50, 1f, "Kavat", 90, 3f, "", 0, "Crescent Vulpaphyla", "S", 95, 3f },
                    { 16, 100, 1f, "Sentinel", 250, 1f, "", 8, "Helios Prime", "SSSSD", 100, 1f },
                    { 34, 50, 1f, "Kavat", 90, 3f, "", 0, "Panzer Vulpaphyla", "S", 95, 3f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchGuns");

            migrationBuilder.DropTable(
                name: "ArchMeleeWeapons");

            migrationBuilder.DropTable(
                name: "Archwings");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "RoboWeapons");

            migrationBuilder.DropTable(
                name: "UserArchGuns");

            migrationBuilder.DropTable(
                name: "UserArchMeleeWeapons");

            migrationBuilder.DropTable(
                name: "UserArchwings");

            migrationBuilder.DropTable(
                name: "UserMeleeWeapon");

            migrationBuilder.DropTable(
                name: "UserPets");

            migrationBuilder.DropTable(
                name: "UserPrimaryWeapons");

            migrationBuilder.DropTable(
                name: "UserRoboWeapons");

            migrationBuilder.DropTable(
                name: "UserSecondaryWeapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeleeWeapon",
                table: "MeleeWeapon");

            migrationBuilder.RenameTable(
                name: "MeleeWeapon",
                newName: "MeleeWeapons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeleeWeapons",
                table: "MeleeWeapons",
                column: "Id");
        }
    }
}
