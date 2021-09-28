using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class SqLiteInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    TriggerType = table.Column<string>(nullable: true),
                    ProjectileType = table.Column<string>(nullable: true),
                    FireRate = table.Column<float>(nullable: false),
                    Accuracy = table.Column<float>(nullable: false),
                    MagazineSize = table.Column<int>(nullable: false),
                    ReloadSeconds = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArchGuns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlueprintResources",
                columns: table => new
                {
                    ResultName = table.Column<string>(nullable: false),
                    ComponentName = table.Column<string>(nullable: false),
                    ResultCategory = table.Column<string>(nullable: true),
                    ComponentCategory = table.Column<string>(nullable: true),
                    ComponentCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintResources", x => new { x.ResultName, x.ComponentName });
                });

            migrationBuilder.CreateTable(
                name: "Frames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    SprintSpeed = table.Column<float>(nullable: false),
                    Polarities = table.Column<string>(nullable: true),
                    ExilusPolarity = table.Column<string>(nullable: true),
                    AuraPolarity = table.Column<string>(nullable: true),
                    SubsumedAbility = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeleeWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    MasteryRankRequired = table.Column<int>(nullable: false),
                    WeaponType = table.Column<string>(nullable: true),
                    RangeMetres = table.Column<float>(nullable: false),
                    AttackSpeed = table.Column<float>(nullable: false),
                    BlockAngleDegrees = table.Column<int>(nullable: false),
                    ComboSeconds = table.Column<float>(nullable: false),
                    FollowThrough = table.Column<float>(nullable: false),
                    Disposition = table.Column<float>(nullable: false),
                    HowToGet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeleeWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                name: "PrimaryWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    table.PrimaryKey("PK_PrimaryWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoboWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                name: "SecondaryWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    Disposition = table.Column<float>(nullable: false),
                    HowToGet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: true),
                    ItemCategory = table.Column<string>(nullable: true),
                    SourceName = table.Column<string>(nullable: true),
                    SourceType = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAmps",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAmps", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserArchGuns",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
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
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
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
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
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
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
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
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
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
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
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
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
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
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoboWeapons", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "UserSecondaryWeapons",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false),
                    OnWishlist = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecondaryWeapons", x => new { x.UserId, x.ItemId });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amps",
                columns: new[] { "Id", "Accuracy", "FireRate", "MagazineSize", "Name", "ProjectileType", "ReloadSeconds", "TriggerType" },
                values: new object[] { 399, 0f, 0f, 0, "Raplak", null, 0f, null });

            migrationBuilder.InsertData(
                table: "Amps",
                columns: new[] { "Id", "Accuracy", "FireRate", "MagazineSize", "Name", "ProjectileType", "ReloadSeconds", "TriggerType" },
                values: new object[] { 400, 0f, 0f, 0, "Shwaak", null, 0f, null });

            migrationBuilder.InsertData(
                table: "Amps",
                columns: new[] { "Id", "Accuracy", "FireRate", "MagazineSize", "Name", "ProjectileType", "ReloadSeconds", "TriggerType" },
                values: new object[] { 401, 0f, 0f, 0, "Granmu", null, 0f, null });

            migrationBuilder.InsertData(
                table: "Amps",
                columns: new[] { "Id", "Accuracy", "FireRate", "MagazineSize", "Name", "ProjectileType", "ReloadSeconds", "TriggerType" },
                values: new object[] { 402, 0f, 0f, 0, "Rahn", null, 0f, null });

            migrationBuilder.InsertData(
                table: "Amps",
                columns: new[] { "Id", "Accuracy", "FireRate", "MagazineSize", "Name", "ProjectileType", "ReloadSeconds", "TriggerType" },
                values: new object[] { 403, 0f, 0f, 0, "Cantic", null, 0f, null });

            migrationBuilder.InsertData(
                table: "Amps",
                columns: new[] { "Id", "Accuracy", "FireRate", "MagazineSize", "Name", "ProjectileType", "ReloadSeconds", "TriggerType" },
                values: new object[] { 404, 0f, 0f, 0, "Lega", null, 0f, null });

            migrationBuilder.InsertData(
                table: "Amps",
                columns: new[] { "Id", "Accuracy", "FireRate", "MagazineSize", "Name", "ProjectileType", "ReloadSeconds", "TriggerType" },
                values: new object[] { 405, 0f, 0f, 0, "Klamora", null, 0f, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 477, 0f, null, 0f, 0f, "", 0, 4, 0, "Velocitus", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 476, 0f, null, 0f, 0f, "", 0, 10, 0, "Prisma Dual Decurion", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 475, 0f, null, 0f, 0f, "", 0, 3, 0, "Phaedra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 474, 0f, null, 0f, 0f, "", 0, 15, 0, "Morgha", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 473, 0f, null, 0f, 0f, "", 0, 14, 0, "Mausolon", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 472, 0f, null, 0f, 0f, "", 0, 8, 0, "Larkspur", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 470, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Ayanga", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 471, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Grattler", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 468, 0f, null, 0f, 0f, "", 0, 0, 0, "Imperator", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 467, 0f, null, 0f, 0f, "", 0, 4, 0, "Grattler", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 466, 0f, null, 0f, 0f, "", 0, 2, 0, "Fluctus", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 465, 0f, null, 0f, 0f, "", 0, 1, 0, "Dual Decurion", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 464, 0f, null, 0f, 0f, "", 0, 4, 0, "Cyngas", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 463, 0f, null, 0f, 0f, "", 0, 1, 0, "Corvas", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 462, 0f, null, 0f, 0f, "", 0, 14, 0, "Cortege", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchGuns",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 469, 0f, null, 0f, 0f, "", 0, 5, 0, "Imperator Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 486, 0f, "", 0, "Veritux", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 485, 0f, "", 6, "Rathbone", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 484, 0f, "", 8, "Prisma Veritux", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 483, 0f, "", 1, "Onorix", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 479, 0f, "", 8, "Centaur", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 481, 0f, "", 4, "Kaszas", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 480, 0f, "", 0, "Ironbridge", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 478, 0f, "", 3, "Agkuza", 0f });

            migrationBuilder.InsertData(
                table: "ArchMeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres" },
                values: new object[] { 482, 0f, "", 7, "Knux", 0f });

            migrationBuilder.InsertData(
                table: "Archwings",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Energy", "EnergyMaxFactor", "FlightSpeed", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 461, 0, 1f, 0, 1.8f, 0f, 0, 3f, "", 0, "Odonata Prime", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Archwings",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Energy", "EnergyMaxFactor", "FlightSpeed", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 460, 0, 1f, 0, 1.8f, 0f, 0, 3f, "", 0, "Odonata", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Archwings",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Energy", "EnergyMaxFactor", "FlightSpeed", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 458, 0, 1f, 0, 1.8f, 0f, 0, 3f, "", 0, "Elytron", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Archwings",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Energy", "EnergyMaxFactor", "FlightSpeed", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 457, 0, 1f, 0, 1.8f, 0f, 0, 3f, "", 0, "Amesha", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Archwings",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Energy", "EnergyMaxFactor", "FlightSpeed", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 459, 0, 1f, 0, 1.8f, 0f, 0, 3f, "", 0, "Itzal", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime", "Credits", "Resource", 25000, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime", "Atlas Prime Neuroptics", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime", "Atlas Prime Chassis", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime", "Atlas Prime Systems", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime", "Orokin Cell", "Resource", 5, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Neuroptics", "Credits", "Resource", 15000, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Neuroptics", "Neural Sensors", "Resource", 2, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Neuroptics", "Cryotic", "Resource", 525, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Neuroptics", "Salvage", "Resource", 4700, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Neuroptics", "Oxium", "Resource", 200, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Chassis", "Credits", "Resource", 15000, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Chassis", "Tellurium", "Resource", 2, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Chassis", "Nitain Extract", "Resource", 2, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Chassis", "Rubedo", "Resource", 725, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Systems", "Credits", "Resource", 15000, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Systems", "Argon Crystal", "Resource", 2, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Systems", "Gallium", "Resource", 4, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Systems", "Polymer Bundle", "Resource", 1200, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Systems", "Alloy Plate", "Resource", 3200, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko", "Credits", "Resource", 20000, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko", "Gallium", "Resource", 5, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko", "Rubedo", "Resource", 700, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko", "Polymer Bundle", "Resource", 3300, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko", "Ankyros", "Weapon", 1, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko Prime", "Credits", "Resource", 20000, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko Prime", "Tekko Prime Blade", "Resource", 2, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko Prime", "Tekko Prime Gauntlet", "Resource", 2, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Tekko Prime", "Orokin Cell", "Resource", 15, "Melee" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Prime Chassis", "Ferrite", "Resource", 3600, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Systems", "Orokin Cell", "Resource", 1, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Systems", "Morphics", "Resource", 5, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Orokin Cell", "Nano Spores", "Resource", 50000, "Resource" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Systems", "Polymer Bundle", "Resource", 1700, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash", "Ash Neuroptics", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash", "Ash Chassis", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash", "Ash Systems", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash", "Credits", "Resource", 25000, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash", "Orokin Cell", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Orokin Cell", "Alloy Plate", "Resource", 50000, "Resource" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Orokin Cell", "Salvage", "Resource", 25000, "Resource" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash Neuroptics", "Credits", "Resource", 15000, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash Neuroptics", "Alloy Plate", "Resource", 150, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash Neuroptics", "Neural Sensors", "Resource", 1, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash Neuroptics", "Rubedo", "Resource", 500, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas", "Credits", "Resource", 30000, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas", "Atlas Neuroptics", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Ash Neuroptics", "Polymer Bundle", "Resource", 150, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas", "Atlas Systems", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Systems", "Ferrite", "Resource", 4600, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Systems", "Credits", "Resource", 15000, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Chassis", "Argon Crystal", "Resource", 2, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Chassis", "Rubedo", "Resource", 700, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas", "Atlas Chassis", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Chassis", "Nano Spores", "Resource", 1800, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Chassis", "Credits", "Resource", 15000, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Chassis", "Cryotic", "Resource", 1300, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Neuroptics", "Neurodes", "Resource", 5, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Neuroptics", "Circuits", "Resource", 800, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Neuroptics", "Alloy Plate", "Resource", 1100, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Neuroptics", "Polymer Bundle", "Resource", 1400, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas Neuroptics", "Credits", "Resource", 15000, "Component" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ResultName", "ComponentName", "ComponentCategory", "ComponentCount", "ResultCategory" },
                values: new object[] { "Atlas", "Orokin Cell", "Resource", 1, "Warframe" });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 51, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Excalibur Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 56, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Inaros Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 55, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 5, "Hydroid Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 54, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Gara Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 53, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Frost Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 52, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Excalibur Umbra", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 57, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Ivara Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 50, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 5, "Equinox Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 42, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Wukong", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 48, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 6, "Chroma Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 47, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 8, "Banshee Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 46, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Atlas Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 45, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Ash Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 44, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Zephyr", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 43, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Yareli", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 58, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 4, "Limbo Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 49, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Ember Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 59, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Loki Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 75, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Vauban Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 61, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 2, "Mesa Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 78, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 6, "Zephyr Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 77, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 5, "Wukong Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 76, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Volt Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 74, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Valkyr Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 73, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Trinity Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 72, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 2, "Titania Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 71, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Octavia Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 60, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Mag Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 70, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Saryn Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 68, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Octavia Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 67, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 8, "Oberon Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 66, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nyx Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 65, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nova Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 64, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nezha Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 63, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nekros Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 62, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 8, "Mirage Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 69, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Rhino Prime", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 41, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Wisp", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 15, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Harrow", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 39, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Valkyr", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 18, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Inaros", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 17, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Hydroid", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 16, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Hildryn", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 14, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Grendel", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 13, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Gauss", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 12, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Garuda", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 11, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Gara", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 19, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Ivara", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 10, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Frost", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 7, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Chroma", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 6, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Baruuk", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 5, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Banshee", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 4, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Atlas", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 3, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Ash", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 2, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Excalibur", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 40, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Vauban", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 8, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Ember", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 20, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Khora", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 9, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Equinox", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 22, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Limbo", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 38, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Trinity", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 21, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Lavos", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 37, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Titania", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 36, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Sevagoth", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 35, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Saryn", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 34, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Revenant", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 32, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Octavia", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 31, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Oberon", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 33, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Protea", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 29, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nova", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 28, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nidus", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 27, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nezha", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 26, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nekros", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 25, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Mesa", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 30, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Nyx", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 23, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Loki", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "Frames",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "AuraPolarity", "Energy", "EnergyMaxFactor", "ExilusPolarity", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor", "SprintSpeed", "SubsumedAbility" },
                values: new object[] { 24, 0, 1f, null, 0, 1.5f, "", 0, 3f, "", 0, "Mag", null, 0, 3f, 0f, 0 });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 371, 0f, 0, 0f, 0f, 0f, "", 7, "Hirudo", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 365, 0f, 0, 0f, 0f, 0f, "", 7, "Halikar", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 366, 0f, 0, 0f, 0f, 0f, "", 13, "Halikar Wraith", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 367, 0f, 0, 0f, 0f, 0f, "", 8, "Hate", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 370, 0f, 0, 0f, 0f, 0f, "", 9, "Heliocor", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 369, 0f, 0, 0f, 0f, 0f, "", 3, "Heat Sword", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 372, 0f, 0, 0f, 0f, 0f, "", 0, "Iron Staff", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 364, 0f, 0, 0f, 0f, 0f, "", 8, "Gunsen", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 368, 0f, 0, 0f, 0f, 0f, "", 3, "Heat Dagger", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 363, 0f, 0, 0f, 0f, 0f, "", 12, "Guandao Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 355, 0f, 0, 0f, 0f, 0f, "", 6, "Galvacord", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 361, 0f, 0, 0f, 0f, 0f, "", 14, "Gram Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 360, 0f, 0, 0f, 0f, 0f, "", 2, "Gram", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 359, 0f, 0, 0f, 0f, 0f, "", 10, "Glaive Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 358, 0f, 0, 0f, 0f, 0f, "", 1, "Glaive", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 357, 0f, 0, 0f, 0f, 0f, "", 5, "Gazal Machete", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 356, 0f, 0, 0f, 0f, 0f, "", 0, "Garuda�s Talons", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 354, 0f, 0, 0f, 0f, 0f, "", 13, "Galatine Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 353, 0f, 0, 0f, 0f, 0f, "", 3, "Galatine", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 373, 0f, 0, 0f, 0f, 0f, "", 5, "Jat Kittag", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 352, 0f, 0, 0f, 0f, 0f, "", 9, "Furax Wraith", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 362, 0f, 0, 0f, 0f, 0f, "", 4, "Guandao", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 374, 0f, 0, 0f, 0f, 0f, "", 11, "Jat Kusar", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 393, 0f, 0, 0f, 0f, 0f, "", 1, "Machete", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 376, 0f, 0, 0f, 0f, 0f, "", 1, "Kama", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 351, 0f, 0, 0f, 0f, 0f, "", 5, "Furax", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 398, 0f, 0, 0f, 0f, 0f, "", 5, "Mire", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 397, 0f, 0, 0f, 0f, 0f, "", 8, "Mios", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 396, 0f, 0, 0f, 0f, 0f, "", 8, "Masseter", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 395, 0f, 0, 0f, 0f, 0f, "", 1, "Magistar", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 394, 0f, 0, 0f, 0f, 0f, "", 11, "Machete Wraith", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 392, 0f, 0, 0f, 0f, 0f, "", 9, "Lesion", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 391, 0f, 0, 0f, 0f, 0f, "", 0, "Lecta", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 390, 0f, 0, 0f, 0f, 0f, "", 7, "Lacera", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 389, 0f, 0, 0f, 0f, 0f, "", 13, "Kuva Shildeg", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 375, 0f, 0, 0f, 0f, 0f, "", 0, "Jaw Sword", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 388, 0f, 0, 0f, 0f, 0f, "", 13, "Kronen Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 386, 0f, 0, 0f, 0f, 0f, "", 9, "Krohkur", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 385, 0f, 0, 0f, 0f, 0f, "", 6, "Kreska", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 384, 0f, 0, 0f, 0f, 0f, "", 9, "Korrudo", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 383, 0f, 0, 0f, 0f, 0f, "", 10, "Kogake Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 382, 0f, 0, 0f, 0f, 0f, "", 2, "Kogake", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 381, 0f, 0, 0f, 0f, 0f, "", 0, "Kestrel", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 380, 0f, 0, 0f, 0f, 0f, "", 7, "Kesheg", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 379, 0f, 0, 0f, 0f, 0f, "", 9, "Keratinos", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 378, 0f, 0, 0f, 0f, 0f, "", 12, "Karyst Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 377, 0f, 0, 0f, 0f, 0f, "", 6, "Karyst", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 387, 0f, 0, 0f, 0f, 0f, "", 3, "Kronen", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 350, 0f, 0, 0f, 0f, 0f, "", 12, "Fragor Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 305, 0f, 0, 0f, 0f, 0f, "", 10, "Arca Titron", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 348, 0f, 0, 0f, 0f, 0f, "", 10, "Fang Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 321, 0f, 0, 0f, 0f, 0f, "", 10, "Dakra Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 320, 0f, 0, 0f, 0f, 0f, "", 0, "Cronus", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 319, 0f, 0, 0f, 0f, 0f, "", 10, "Cobra & Crane", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 318, 0f, 0, 0f, 0f, 0f, "", 12, "Ceti Lacera", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 317, 0f, 0, 0f, 0f, 0f, "", 7, "Cerata", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 315, 0f, 0, 0f, 0f, 0f, "", 7, "Cautacyst", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 314, 0f, 0, 0f, 0f, 0f, "", 5, "Cassowar", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 313, 0f, 0, 0f, 0f, 0f, "", 4, "Cadus", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 312, 0f, 0, 0f, 0f, 0f, "", 10, "Broken War", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 311, 0f, 0, 0f, 0f, 0f, "", 7, "Broken Scepter", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 310, 0f, 0, 0f, 0f, 0f, "", 4, "Boltace", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 309, 0f, 0, 0f, 0f, 0f, "", 5, "Bo Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 308, 0f, 0, 0f, 0f, 0f, "", 4, "Bo", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 307, 0f, 0, 0f, 0f, 0f, "", 5, "Atterax", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 306, 0f, 0, 0f, 0f, 0f, "", 11, "Arum Spinosa", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 304, 0f, 0, 0f, 0f, 0f, "", 8, "Ankyros Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 303, 0f, 0, 0f, 0f, 0f, "", 2, "Ankyros", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 302, 0f, 0, 0f, 0f, 0f, "", 3, "Anku", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 301, 0f, 0, 0f, 0f, 0f, "", 5, "Amphis", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 300, 0f, 0, 0f, 0f, 0f, "", 3, "Ack & Brunt", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 349, 0f, 0, 0f, 0f, 0f, "", 2, "Fragor", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 322, 0f, 0, 0f, 0f, 0f, "", 2, "Dark Dagger", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 323, 0f, 0, 0f, 0f, 0f, "", 5, "Dark Split-Sword", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 316, 0f, 0, 0f, 0f, 0f, "", 3, "Ceramic Dagger", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 325, 0f, 0, 0f, 0f, 0f, "", 0, "Desert Wind", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 347, 0f, 0, 0f, 0f, 0f, "", 0, "Fang", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 346, 0f, 0, 0f, 0f, 0f, "", 8, "Falcor", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 345, 0f, 0, 0f, 0f, 0f, "", 0, "Exalted Blade", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 344, 0f, 0, 0f, 0f, 0f, "", 7, "Ether Sword", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 343, 0f, 0, 0f, 0f, 0f, "", 4, "Ether Reaper", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 324, 0f, 0, 0f, 0f, 0f, "", 8, "Dark Sword", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 341, 0f, 0, 0f, 0f, 0f, "", 7, "Endura", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 340, 0f, 0, 0f, 0f, 0f, "", 2, "Dual Zoren", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 339, 0f, 0, 0f, 0f, 0f, "", 0, "Dual Skana", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 338, 0f, 0, 0f, 0f, 0f, "", 6, "Dual Raza", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 337, 0f, 0, 0f, 0f, 0f, "", 7, "Dual Keres", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 342, 0f, 0, 0f, 0f, 0f, "", 6, "Ether Daggers", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 335, 0f, 0, 0f, 0f, 0f, "", 1, "Dual Kamas", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 336, 0f, 0, 0f, 0f, 0f, "", 8, "Dual Kamas Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 327, 0f, 0, 0f, 0f, 0f, "", 10, "Destreza Prime", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 328, 0f, 0, 0f, 0f, 0f, "", 6, "Dex Dakra", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 330, 0f, 0, 0f, 0f, 0f, "", 8, "Dragon Nikana", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 331, 0f, 0, 0f, 0f, 0f, "", 5, "Dual Cleavers", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 329, 0f, 0, 0f, 0f, 0f, "", 0, "Diwata", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 332, 0f, 0, 0f, 0f, 0f, "", 8, "Dual Ether", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 333, 0f, 0, 0f, 0f, 0f, "", 3, "Dual Heat Swords", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 334, 0f, 0, 0f, 0f, 0f, "", 6, "Dual Ichor", 0f, null });

            migrationBuilder.InsertData(
                table: "MeleeWeapons",
                columns: new[] { "Id", "AttackSpeed", "BlockAngleDegrees", "ComboSeconds", "Disposition", "FollowThrough", "HowToGet", "MasteryRankRequired", "Name", "RangeMetres", "WeaponType" },
                values: new object[] { 326, 0f, 0, 0f, 0f, 0f, "", 7, "Destreza", 0f, null });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 424, 0, 1f, "Sentinel", 0, 3f, "", 0, "Shade", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 429, 0, 1f, "MOA", 0, 3f, "", 0, "Lambeo", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 426, 0, 1f, "Sentinel", 0, 3f, "", 0, "Taxon", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 427, 0, 1f, "Sentinel", 0, 3f, "", 0, "Wyrm Prime", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 428, 0, 1f, "MOA", 0, 3f, "", 0, "Para", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 430, 0, 1f, "MOA", 0, 3f, "", 0, "Oloro", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 435, 0, 1f, "Kavat", 0, 3f, "", 0, "Venari", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 432, 0, 1f, "Kavat", 0, 3f, "", 0, "Adarza", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 433, 0, 1f, "Kavat", 0, 3f, "", 0, "Smeeta", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 434, 0, 1f, "Kavat", 0, 3f, "", 0, "Vasca", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 436, 0, 1f, "Kavat", 0, 3f, "", 0, "Sly Vulpaphyla", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 437, 0, 1f, "Kavat", 0, 3f, "", 0, "Crescent Vulpaphyla", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 438, 0, 1f, "Kavat", 0, 3f, "", 0, "Panzer Vulpaphyla", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 423, 0, 1f, "Sentinel", 0, 3f, "", 0, "Oxylus", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 431, 0, 1f, "MOA", 0, 3f, "", 0, "Nychus", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 422, 0, 1f, "Sentinel", 0, 3f, "", 0, "Nautilus", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 425, 0, 1f, "Sentinel", 0, 3f, "", 0, "Prisma Shade", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 420, 0, 1f, "Sentinel", 0, 3f, "", 0, "Helios", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 421, 0, 1f, "Sentinel", 0, 3f, "", 8, "Helios Prime", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 406, 0, 1f, "Kubrow", 0, 3f, "", 0, "Huras", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 408, 0, 1f, "Kubrow", 0, 3f, "", 0, "Sahasa", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 409, 0, 1f, "Kubrow", 0, 3f, "", 0, "Sunika", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 410, 0, 1f, "Kubrow", 0, 3f, "", 0, "Chesa", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 411, 0, 1f, "Kubrow", 0, 3f, "", 0, "Helminth Charger", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 412, 0, 1f, "Kubrow", 0, 3f, "", 0, "Vizier Predasite", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 407, 0, 1f, "Kubrow", 0, 3f, "", 0, "Raksa", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 414, 0, 1f, "Kubrow", 0, 3f, "", 0, "Medjay Predasite", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 415, 0, 1f, "Sentinel", 0, 3f, "", 0, "Carrier", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 416, 0, 1f, "Sentinel", 0, 3f, "", 0, "Carrier Prime", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 417, 0, 1f, "Sentinel", 0, 3f, "", 0, "Dethcube", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 418, 0, 1f, "Sentinel", 0, 3f, "", 0, "Diriga", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 413, 0, 1f, "Kubrow", 0, 3f, "", 0, "Pharaoh Predasite", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Armor", "ArmorMaxFactor", "Category", "Health", "HealthMaxFactor", "HowToGet", "MasteryRankRequired", "Name", "Polarities", "Shield", "ShieldMaxFactor" },
                values: new object[] { 419, 0, 1f, "Sentinel", 0, 3f, "", 0, "Djinn", null, 0, 3f });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 153, 0f, null, 0f, 0f, "", 0, 6, 0, "Miter", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 154, 0f, null, 0f, 0f, "", 0, 0, 0, "Mk1-Braton", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 155, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Paris", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 156, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Strun", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 157, 0f, null, 0f, 0f, "", 0, 7, 0, "Mutalist Cernos", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 159, 0f, null, 0f, 0f, "", 0, 9, 0, "Nagantaka", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 160, 0f, null, 0f, 0f, "", 0, 9, 0, "Ogris", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 161, 0f, null, 0f, 0f, "", 0, 14, 0, "Opticor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 162, 0f, null, 0f, 0f, "", 0, 14, 0, "Opticor Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 152, 0f, null, 0f, 0f, "", 0, 8, 0, "Lenz", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 158, 0f, null, 0f, 0f, "", 0, 2, 0, "Mutalist Quanta", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 151, 0f, null, 0f, 0f, "", 0, 7, 0, "Latron Wraith", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 144, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Ogris", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 149, 0f, null, 0f, 0f, "", 0, 0, 0, "Latron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 148, 0f, null, 0f, 0f, "", 0, 10, 0, "Lanka", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 147, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Zarr", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 146, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Tonkor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 145, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Quartakk", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 163, 0f, null, 0f, 0f, "", 0, 7, 0, "Pathera", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 143, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Kohm", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 142, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Karak", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 141, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Hind", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 140, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Hek", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 139, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Drakgoon", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 138, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Cakkhurr", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 150, 0f, null, 0f, 0f, "", 0, 10, 0, "Latron Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 164, 0f, null, 0f, 0f, "", 0, 14, 0, "Panthera Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 172, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Grakata", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 166, 0f, null, 0f, 0f, "", 0, 3, 0, "Paris", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 137, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Bramma", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 191, 0f, null, 0f, 0f, "", 0, 7, 0, "Sobek", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 190, 0f, null, 0f, 0f, "", 0, 0, 0, "Soaktron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 189, 0f, null, 0f, 0f, "", 0, 5, 0, "Snipetron Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 188, 0f, null, 0f, 0f, "", 0, 0, 0, "Snipetron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 187, 0f, null, 0f, 0f, "", 0, 5, 0, "Simulor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 186, 0f, null, 0f, 0f, "", 0, 13, 0, "Shedu", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 185, 0f, null, 0f, 0f, "", 0, 12, 0, "Secura Penta", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 184, 0f, null, 0f, 0f, "", 0, 6, 0, "Scourge", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 183, 0f, null, 0f, 0f, "", 0, 12, 0, "Sancti Tigris", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 182, 0f, null, 0f, 0f, "", 0, 12, 0, "Rubico Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 181, 0f, null, 0f, 0f, "", 0, 6, 0, "Rubico", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 180, 0f, null, 0f, 0f, "", 0, 12, 0, "Rakta Cernos", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 179, 0f, null, 0f, 0f, "", 0, 12, 0, "Quellor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 178, 0f, null, 0f, 0f, "", 0, 10, 0, "Quartakk", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 177, 0f, null, 0f, 0f, "", 0, 10, 0, "Quanta Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 176, 0f, null, 0f, 0f, "", 0, 4, 0, "Quanta", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 175, 0f, null, 0f, 0f, "", 0, 15, 0, "Proboscis Cernos", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 174, 0f, null, 0f, 0f, "", 0, 4, 0, "Prisma Tetra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 173, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Grinlok", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 171, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Gorgon", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 170, 0f, null, 0f, 0f, "", 0, 9, 0, "Phantasma", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 169, 0f, null, 0f, 0f, "", 0, 11, 0, "Phage", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 168, 0f, null, 0f, 0f, "", 0, 6, 0, "Penta", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 167, 0f, null, 0f, 0f, "", 0, 8, 0, "Paris Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 165, 0f, null, 0f, 0f, "", 0, 7, 0, "Paracyst", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 136, 0f, null, 0f, 0f, "", 0, 8, 0, "Komorex", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 121, 0f, null, 0f, 0f, "", 0, 12, 0, "Glaxion Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 134, 0f, null, 0f, 0f, "", 0, 7, 0, "Karak Wraith", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 103, 0f, null, 0f, 0f, "", 0, 10, 0, "Battacor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 102, 0f, null, 0f, 0f, "", 0, 11, 0, "Basmu", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 101, 0f, null, 0f, 0f, "", 0, 11, 0, "Buzlok", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 100, 0f, null, 0f, 0f, "", 0, 12, 0, "Burston Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 99, 0f, null, 0f, 0f, "", 0, 0, 0, "Burston", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 98, 0f, null, 0f, 0f, "", 0, 13, 0, "Bubunico", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 97, 0f, null, 0f, 0f, "", 0, 4, 0, "Braton Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 96, 0f, null, 0f, 0f, "", 0, 8, 0, "Braton Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 95, 0f, null, 0f, 0f, "", 0, 0, 0, "Braton", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 94, 0f, null, 0f, 0f, "", 0, 13, 0, "Boltor Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 93, 0f, null, 0f, 0f, "", 0, 2, 0, "Boltor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 92, 0f, null, 0f, 0f, "", 0, 11, 0, "Boar Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 91, 0f, null, 0f, 0f, "", 0, 2, 0, "Boar", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 90, 0f, null, 0f, 0f, "", 0, 10, 0, "Baza Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 89, 0f, null, 0f, 0f, "", 0, 7, 0, "Baza", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 88, 0f, null, 0f, 0f, "", 0, 0, 0, "Artemis Bow", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 87, 0f, null, 0f, 0f, "", 0, 7, 0, "Argonak", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 86, 0f, null, 0f, 0f, "", 0, 10, 0, "Arca Plasmor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 85, 0f, null, 0f, 0f, "", 0, 10, 0, "Amprex", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 84, 0f, null, 0f, 0f, "", 0, 10, 0, "Ambassador", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 83, 0f, null, 0f, 0f, "", 0, 7, 0, "Attica", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 82, 0f, null, 0f, 0f, "", 0, 14, 0, "Astilla Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 81, 0f, null, 0f, 0f, "", 0, 10, 0, "Astilla", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 80, 0f, null, 0f, 0f, "", 0, 14, 0, "Corinth", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 79, 0f, null, 0f, 0f, "", 0, 8, 0, "Acceltra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 104, 0f, null, 0f, 0f, "", 0, 6, 0, "Carmine Penta", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 105, 0f, null, 0f, 0f, "", 0, 10, 0, "Cedo", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 135, 0f, null, 0f, 0f, "", 0, 5, 0, "Kohm", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 107, 0f, null, 0f, 0f, "", 0, 10, 0, "Cernos Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 106, 0f, null, 0f, 0f, "", 0, 10, 0, "Cernos", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 133, 0f, null, 0f, 0f, "", 0, 1, 0, "Karak", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 131, 0f, null, 0f, 0f, "", 0, 9, 0, "Ignis Wraith", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 130, 0f, null, 0f, 0f, "", 0, 5, 0, "Ignis", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 129, 0f, null, 0f, 0f, "", 0, 0, 0, "Hind", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 128, 0f, null, 0f, 0f, "", 0, 7, 0, "Hema", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 127, 0f, null, 0f, 0f, "", 0, 4, 0, "Hek", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 126, 0f, null, 0f, 0f, "", 0, 7, 0, "Harpak", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 125, 0f, null, 0f, 0f, "", 0, 7, 0, "Grinlok", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 124, 0f, null, 0f, 0f, "", 0, 5, 0, "Grakata", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 123, 0f, null, 0f, 0f, "", 0, 7, 0, "Gorgon Wraith", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 122, 0f, null, 0f, 0f, "", 0, 3, 0, "Gorgon", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 132, 0f, null, 0f, 0f, "", 0, 7, 0, "Javlok", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 112, 0f, null, 0f, 0f, "", 0, 7, 0, "Dera Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 119, 0f, null, 0f, 0f, "", 0, 8, 0, "Fulmin", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 118, 0f, null, 0f, 0f, "", 0, 6, 0, "Flux Rifle", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 117, 0f, null, 0f, 0f, "", 0, 14, 0, "Ferrox", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 116, 0f, null, 0f, 0f, "", 0, 8, 0, "Exergis", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 115, 0f, null, 0f, 0f, "", 0, 5, 0, "Dread", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 114, 0f, null, 0f, 0f, "", 0, 5, 0, "Drakgoon", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 113, 0f, null, 0f, 0f, "", 0, 7, 0, "Dex Sybaris", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 120, 0f, null, 0f, 0f, "", 0, 8, 0, "Gaxion", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 111, 0f, null, 0f, 0f, "", 0, 4, 0, "Dera", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 110, 0f, null, 0f, 0f, "", 0, 10, 0, "Daikyu", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 108, 0f, null, 0f, 0f, "", 0, 7, 0, "Convectrix", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "PrimaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 109, 0f, null, 0f, 0f, "", 0, 14, 0, "Corinth Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 540, "Cryptographic Alu" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 554, "Detonite Ampule" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 555, "Detonite Injector" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 556, "Devar" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 561, "Echowinder Anoscopic Sensor" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 558, "Diluted Thermia" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 559, "Dusklight Sarracenia" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 560, "Dusky-Headed Virmink Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 553, "Dentrite Blastoma" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 557, "Devolved Namalon" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 552, "Delta Beacon" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 546, "Damaged Necranech Pod" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 550, "Damaged Necramech Weapon Stock" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 549, "Damaged Necramech Weapon Receiver" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 548, "Damaged Necramech Weapon Pod" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 547, "Damaged Necramech Weapon Barrel" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 545, "Damaged Necramech Engine" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 544, "Damaged Necramech Casing" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 543, "Dagonic" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 542, "Cuthol Tendrils" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 541, "Cubic Diodes" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 562, "Embolos" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 551, "Delicate Pobber Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 563, "Esher Devar" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 576, "Frostcap" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 565, "Faceted Tiametrite" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 588, "Credits" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 587, "Rubedo" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 586, "Green Velocipod Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 585, "Gorgaricus Spore" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 584, "Goopolla Spleen" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 583, "Goblite Tears" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 582, "Goblite" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 581, "Ganglion" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 580, "Gamma Beacon" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 579, "Gallos Rods" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 578, "Gallium" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 577, "Frostleaf" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 539, "Cryotic" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 575, "Fresnels" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 574, "Fish Scales" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 573, "Fish Oil" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 572, "Fish Meat" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 571, "Fieldron Sample" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 570, "Fieldron" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 569, "Fersteel Alloy" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 568, "Ferros" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 567, "Ferrite" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 566, "Ferment Bladder" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 564, "Eye-Eye Rotoblade" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 538, "Crisma Toroid" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 528, "Control Module" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 536, "Crescent Vulpaphyla Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 508, "Bonewidow Capsule" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 537, "Crimzian" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 506, "Biotic Filter" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 505, "Beta Corruptor" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 504, "Benign Infested Tumor" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 503, "Bapholite" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 502, "Azurite" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 501, "Axidrol Alloy" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 500, "Axidite" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 499, "Auroxium Alloy" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 509, "Bonewidow Casing" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 498, "Auron" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 496, "Atmo Systems" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 495, "Asterite" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 494, "Argon Crystal" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 493, "Antiserum Injector Fragment" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 492, "Anomaly Shard" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 491, "Amarast" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 490, "Alpha Corruptor" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 489, "Alloy Plate" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 488, "Adramalium" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 487, "Adramal Alloy" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 497, "Aucrux Capacitors" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 510, "Bonewidow Engine" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 507, "Black-Banded Bolarola Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 512, "Bracoid" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 535, "Cranial Foremount" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 534, "Cortege Stock" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 533, "Cortege Receiver" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 532, "Cortege Barrel" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 531, "Coprun" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 530, "Coprite Alloy" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 529, "Copernics" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 511, "Bonewidow Weapon Pod" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 526, "Common Avichaea Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 525, "Circuits" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 524, "Charc Electroplax" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 527, "Condroc Wing" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 522, "Cetus Wisp" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 523, "Charmote Sagan Module" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 514, "Brickie Muon Battery" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 515, "Brindle Kubrodon Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 516, "Burrowing Cryptilex Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 513, "Breath of the Eidolon" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 518, "Calda Toroid" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 519, "Carbides" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 520, "Caustic Cryptilex Tag" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 521, "Cerulean Fungus Extract" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[] { 517, "Cabrochon Embolos" });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 456, 0f, null, 0f, 0f, "", 0, 0, 0, "Vulklok", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 455, 0f, null, 0f, 0f, "", 0, 0, 0, "Laser Rifle", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 454, 0f, null, 0f, 0f, "", 0, 14, 0, "Vulcax", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 453, 0f, null, 0f, 0f, "", 0, 0, 0, "Verglas", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 452, 0f, null, 0f, 0f, "", 0, 3, 0, "Tazicor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 451, 0f, null, 0f, 0f, "", 0, 0, 0, "Sweeper Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 450, 0f, null, 0f, 0f, "", 0, 0, 0, "Sweeper", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 449, 0f, null, 0f, 0f, "", 0, 0, 0, "Stinger", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 448, 0f, null, 0f, 0f, "", 0, 0, 0, "Prisma Burst Laser", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 446, 0f, null, 0f, 0f, "", 0, 3, 0, "Multron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 445, 0f, null, 0f, 0f, "", 0, 0, 0, "Helstrum", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 444, 0f, null, 0f, 0f, "", 0, 0, 0, "Deth Machine Rifle", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 443, 0f, null, 0f, 0f, "", 0, 8, 0, "Deconstructor Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 442, 0f, null, 0f, 0f, "", 0, 0, 0, "Deconstructor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 441, 0f, null, 0f, 0f, "", 0, 0, 0, "Cryotra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 440, 0f, null, 0f, 0f, "", 0, 0, 0, "Burst Laser", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 439, 0f, null, 0f, 0f, "", 0, 0, 0, "Artax", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "RoboWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 447, 0f, null, 0f, 0f, "", 0, 0, 0, "Prime Laser Rifle", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 262, 0f, null, 0f, 0f, "", 0, 7, 0, "Marelok", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 263, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Furis", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 264, 0f, null, 0f, 0f, "", 0, 0, 0, "MK1-Kunai", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 265, 0f, null, 0f, 0f, "", 0, 4, 0, "Nukor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 270, 0f, null, 0f, 0f, "", 0, 9, 0, "Pox", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 268, 0f, null, 0f, 0f, "", 0, 14, 0, "Pandero Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 269, 0f, null, 0f, 0f, "", 0, 6, 0, "Plinx", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 261, 0f, null, 0f, 0f, "", 0, 9, 0, "Mara Detron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 271, 0f, null, 0f, 0f, "", 0, 8, 0, "Prisma Angstrum", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 266, 0f, null, 0f, 0f, "", 0, 8, 0, "Ocucor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 260, 0f, null, 0f, 0f, "", 0, 10, 0, "Magnus", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 256, 0f, null, 0f, 0f, "", 0, 14, 0, "Lato Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 258, 0f, null, 0f, 0f, "", 0, 3, 0, "Lex", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 257, 0f, null, 0f, 0f, "", 0, 7, 0, "Lato Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 272, 0f, null, 0f, 0f, "", 0, 11, 0, "Prisma Twin Gremlins", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 255, 0f, null, 0f, 0f, "", 0, 0, 0, "Lato", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 254, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Twin Stubbas", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 253, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Seer", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 252, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Nukor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 251, 0f, null, 0f, 0f, "", 0, 15, 0, "Kuva Kraken", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 250, 0f, null, 0f, 0f, "", 0, 13, 0, "Kuva Brakk", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 249, 0f, null, 0f, 0f, "", 0, 2, 0, "Kunai", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 248, 0f, null, 0f, 0f, "", 0, 5, 0, "Kulstar", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 259, 0f, null, 0f, 0f, "", 0, 8, 0, "Lex Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 273, 0f, null, 0f, 0f, "", 0, 12, 0, "Pyrana", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 277, 0f, null, 0f, 0f, "", 0, 0, 0, "Regulators", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 275, 0f, null, 0f, 0f, "", 0, 9, 0, "Quatz", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 299, 0f, null, 0f, 0f, "", 0, 9, 0, "Twin Grakatas", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 298, 0f, null, 0f, 0f, "", 0, 14, 0, "Tenet Spirex", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 297, 0f, null, 0f, 0f, "", 0, 16, 0, "Tenet Diplos", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 296, 0f, null, 0f, 0f, "", 0, 16, 0, "Tenet Detron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 295, 0f, null, 0f, 0f, "", 0, 14, 0, "Tenet Cycron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 294, 0f, null, 0f, 0f, "", 0, 11, 0, "Telos Akbolto", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 293, 0f, null, 0f, 0f, "", 0, 8, 0, "Talons", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 292, 0f, null, 0f, 0f, "", 0, 7, 0, "Synoid Gammacor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 291, 0f, null, 0f, 0f, "", 0, 2, 0, "Stug", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 290, 0f, null, 0f, 0f, "", 0, 7, 0, "Stubba", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 289, 0f, null, 0f, 0f, "", 0, 10, 0, "Staticor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 274, 0f, null, 0f, 0f, "", 0, 13, 0, "Pyrana Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 288, 0f, null, 0f, 0f, "", 0, 10, 0, "Spira Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 286, 0f, null, 0f, 0f, "", 0, 10, 0, "Spectra Vandal", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 285, 0f, null, 0f, 0f, "", 0, 4, 0, "Spectra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 284, 0f, null, 0f, 0f, "", 0, 2, 0, "Sonicor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 283, 0f, null, 0f, 0f, "", 0, 14, 0, "Sicarus Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 282, 0f, null, 0f, 0f, "", 0, 3, 0, "Sicarus", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 281, 0f, null, 0f, 0f, "", 0, 14, 0, "Sepulcrum", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 280, 0f, null, 0f, 0f, "", 0, 0, 0, "Seer", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 279, 0f, null, 0f, 0f, "", 0, 10, 0, "Secura Dual Cestra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 278, 0f, null, 0f, 0f, "", 0, 10, 0, "Sancti Castanas", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 247, 0f, null, 0f, 0f, "", 0, 0, 0, "Kraken", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 276, 0f, null, 0f, 0f, "", 0, 6, 0, "Rakta Ballistica", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 287, 0f, null, 0f, 0f, "", 0, 8, 0, "Spira", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 246, 0f, null, 0f, 0f, "", 0, 8, 0, "Kompressa", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 267, 0f, null, 0f, 0f, "", 0, 8, 0, "Pandero", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 244, 0f, null, 0f, 0f, "", 0, 10, 0, "Knell", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 215, 0f, null, 0f, 0f, "", 0, 5, 0, "Atomos", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 214, 0f, null, 0f, 0f, "", 0, 10, 0, "Athodai", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 213, 0f, null, 0f, 0f, "", 0, 10, 0, "Arca Scisco", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 212, 0f, null, 0f, 0f, "", 0, 4, 0, "Angstrum", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 211, 0f, null, 0f, 0f, "", 0, 4, 0, "Akszani", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 210, 0f, null, 0f, 0f, "", 0, 12, 0, "Akvasto Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 209, 0f, null, 0f, 0f, "", 0, 8, 0, "Akvasto", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 208, 0f, null, 0f, 0f, "", 0, 10, 0, "Akstiletto Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 207, 0f, null, 0f, 0f, "", 0, 8, 0, "Akstiletto", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 206, 0f, null, 0f, 0f, "", 0, 12, 0, "Aksomati Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 205, 0f, null, 0f, 0f, "", 0, 9, 0, "Aksomati", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 216, 0f, null, 0f, 0f, "", 0, 6, 0, "Azima", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 204, 0f, null, 0f, 0f, "", 0, 12, 0, "Akmagnus", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 202, 0f, null, 0f, 0f, "", 0, 4, 0, "Aklex", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 201, 0f, null, 0f, 0f, "", 0, 3, 0, "Aklato", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 200, 0f, null, 0f, 0f, "", 0, 12, 0, "Akjagara Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 199, 0f, null, 0f, 0f, "", 0, 8, 0, "Akjagara", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 198, 0f, null, 0f, 0f, "", 0, 10, 0, "Akbronco Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 197, 0f, null, 0f, 0f, "", 0, 2, 0, "Akbronco", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 196, 0f, null, 0f, 0f, "", 0, 13, 0, "Akbolto Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 195, 0f, null, 0f, 0f, "", 0, 9, 0, "Akbolto", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 194, 0f, null, 0f, 0f, "", 0, 8, 0, "Akarius", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 193, 0f, null, 0f, 0f, "", 0, 4, 0, "Afuris", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 245, 0f, null, 0f, 0f, "", 0, 5, 0, "Kohomak", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 203, 0f, null, 0f, 0f, "", 0, 15, 0, "Aklex Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 217, 0f, null, 0f, 0f, "", 0, 0, 0, "Balefire Charger", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 192, 0f, null, 0f, 0f, "", 0, 7, 0, "Acrid", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 219, 0f, null, 0f, 0f, "", 0, 14, 0, "Ballistica Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 243, 0f, null, 0f, 0f, "", 0, 7, 0, "Hystrix", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 242, 0f, null, 0f, 0f, "", 0, 4, 0, "Hikou Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 241, 0f, null, 0f, 0f, "", 0, 2, 0, "Hikou", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 240, 0f, null, 0f, 0f, "", 0, 2, 0, "Gammacor", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 239, 0f, null, 0f, 0f, "", 0, 7, 0, "Fusilai", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 238, 0f, null, 0f, 0f, "", 0, 2, 0, "Furis", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 218, 0f, null, 0f, 0f, "", 0, 2, 0, "Ballistica", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 236, 0f, null, 0f, 0f, "", 0, 8, 0, "Epitaph", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 235, 0f, null, 0f, 0f, "", 0, 9, 0, "Embolist", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 234, 0f, null, 0f, 0f, "", 0, 11, 0, "Dual Toxocyst", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 233, 0f, null, 0f, 0f, "", 0, 7, 0, "Dual Cestra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 232, 0f, null, 0f, 0f, "", 0, 0, 0, "Dex Pixia", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 237, 0f, null, 0f, 0f, "", 0, 14, 0, "Euphona Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 230, 0f, null, 0f, 0f, "", 0, 6, 0, "Detron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 229, 0f, null, 0f, 0f, "", 0, 4, 0, "Despair", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 228, 0f, null, 0f, 0f, "", 0, 8, 0, "Cycron", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 227, 0f, null, 0f, 0f, "", 0, 8, 0, "Cyanex", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 226, 0f, null, 0f, 0f, "", 0, 4, 0, "Cestra", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 225, 0f, null, 0f, 0f, "", 0, 11, 0, "Catabolyst", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 224, 0f, null, 0f, 0f, "", 0, 3, 0, "Castanas", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 223, 0f, null, 0f, 0f, "", 0, 4, 0, "Bronco Prime", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 222, 0f, null, 0f, 0f, "", 0, 0, 0, "Bronco", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 221, 0f, null, 0f, 0f, "", 0, 6, 0, "Brakk", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 220, 0f, null, 0f, 0f, "", 0, 7, 0, "Bolto", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Accuracy", "AmmoType", "Disposition", "FireRate", "HowToGet", "MagazineSize", "MasteryRankRequired", "MaxAmmo", "Name", "ProjectileType", "ReloadSeconds", "TriggerType", "WeaponType" },
                values: new object[] { 231, 0f, null, 0f, 0f, "", 0, 10, 0, "Dex Furis", null, 0f, null, null });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 37, "Blueprint", "Ash Prime Neuroptics Blueprint", "Neo A5", "Relic", "Rare" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 36, "Blueprint", "Ash Prime Neuroptics Blueprint", "Axi A9", "Relic", "Rare" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 35, "Blueprint", "Ash Prime Neuroptics Blueprint", "Axi A6", "Relic", "Rare" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 34, "Blueprint", "Ash Prime Neuroptics Blueprint", "Axi A11", "Relic", "Rare" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 28, "Blueprint", "Ash Prime Systems Blueprint", "Lith N4", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 32, "Blueprint", "Ash Prime Systems Blueprint", "Neo A3", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 31, "Blueprint", "Ash Prime Systems Blueprint", "Meso I1", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 30, "Blueprint", "Ash Prime Systems Blueprint", "Meso G2", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 29, "Blueprint", "Ash Prime Systems Blueprint", "Meso C4", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 33, "Blueprint", "Ash Prime Systems Blueprint", "Neo N15", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 38, "Blueprint", "Tekko Blueprint", "Market", "Market", "25000" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 50, "Blueprint", "Tekko Prime Blade Blueprint", "Axi T6", "Relic", "Rare" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 40, "Blueprint", "Tekko Prime Blueprint", "Lith P5", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 41, "Blueprint", "Tekko Prime Blueprint", "Meso E4", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 42, "Blueprint", "Tekko Prime Blueprint", "Neo B7", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 43, "Blueprint", "Tekko Prime Gauntlet Blueprint", "Axi C5", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 44, "Blueprint", "Tekko Prime Gauntlet Blueprint", "Axi G4", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 45, "Blueprint", "Tekko Prime Gauntlet Blueprint", "Axi W2", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 46, "Blueprint", "Tekko Prime Gauntlet Blueprint", "Lith T4", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 47, "Blueprint", "Tekko Prime Gauntlet Blueprint", "Meso N9", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 48, "Blueprint", "Tekko Prime Gauntlet Blueprint", "Meso T5", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 49, "Blueprint", "Tekko Prime Gauntlet Blueprint", "Meso W1", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 27, "Blueprint", "Ash Prime Chassis Blueprint", "Neo T3", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 39, "Blueprint", "Tekko Prime Blueprint", "Lith L2", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 26, "Blueprint", "Ash Prime Chassis Blueprint", "Neo M3", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 13, "Blueprint", "Atlas Chassis Blueprint", "Jordas Golem", "Boss", "38.72" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 24, "Blueprint", "Ash Prime Chassis Blueprint", "Meso E3", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 51, "Blueprint", "Tekko Prime Blade Blueprint", "Axi T7", "Relic", "Rare" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 1, "Blueprint", "Ash Blueprint", "Market", "Market", "35000" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 2, "Blueprint", "Ash Neuroptics Blueprint", "Grineer Manic", "Drop", "12.78" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 3, "Blueprint", "Ash Chassis Blueprint", "Grineer Manic", "Drop", "12.78" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 4, "Blueprint", "Ash Systems Blueprint", "Grineer Manic", "Drop", "7.44" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 5, "Blueprint", "Ash Prime Neuroptics Blueprint", "Axi N2", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 6, "Blueprint", "Ash Prime Neuroptics Blueprint", "Meso N2", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 7, "Blueprint", "Ash Prime Neuroptics Blueprint", "Meso V4", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 8, "Blueprint", "Ash Prime Neuroptics Blueprint", "Neo A4", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 9, "Blueprint", "Ash Prime Neuroptics Blueprint", "Neo N3", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 10, "Blueprint", "Ash Prime Neuroptics Blueprint", "Neo V4", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 11, "Blueprint", "Atlas Blueprint", "Jordas Precept", "Quest", "" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 12, "Blueprint", "Atlas Blueprint", "Cephalon Simaris", "Standing-Simaris", "50000" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 14, "Blueprint", "Atlas Neuroptics Blueprint", "Jordas Golem", "Boss", "38.72" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 15, "Blueprint", "Atlas Systems Blueprint", "Jordas Golem", "Boss", "22.56" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 16, "Blueprint", "Atlas Prime Blueprint", "Lith D1", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 17, "Blueprint", "Atlas Prime Blueprint", "Lith K6", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 18, "Blueprint", "Atlas Prime Blueprint", "Lith M5", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 19, "Blueprint", "Atlas Prime Blueprint", "Lith P3", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 20, "Blueprint", "Atlas Prime Blueprint", "Lith P5", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 21, "Blueprint", "Atlas Prime Blueprint", "Neo Z7", "Relic", "Common" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 22, "Blueprint", "Ash Prime Chassis Blueprint", "Axi B3", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 23, "Blueprint", "Ash Prime Chassis Blueprint", "Lith B8", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 25, "Blueprint", "Ash Prime Chassis Blueprint", "Neo E2", "Relic", "Uncommon" });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "ItemCategory", "ItemName", "SourceName", "SourceType", "Value" },
                values: new object[] { 52, "Blueprint", "Tekko Prime Blade Blueprint", "Neo T2", "Relic", "Rare" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amps");

            migrationBuilder.DropTable(
                name: "ArchGuns");

            migrationBuilder.DropTable(
                name: "ArchMeleeWeapons");

            migrationBuilder.DropTable(
                name: "Archwings");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlueprintResources");

            migrationBuilder.DropTable(
                name: "Frames");

            migrationBuilder.DropTable(
                name: "MeleeWeapons");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "PrimaryWeapons");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "RoboWeapons");

            migrationBuilder.DropTable(
                name: "SecondaryWeapons");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "UserAmps");

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

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
