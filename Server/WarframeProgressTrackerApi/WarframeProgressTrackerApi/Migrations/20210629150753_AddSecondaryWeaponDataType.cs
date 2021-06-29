using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddSecondaryWeaponDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SecondaryWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Disposition = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryWeapons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecondaryWeapons");
        }
    }
}
