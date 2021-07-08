using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddAmpDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "UserAmps",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    MasteryRank = table.Column<int>(nullable: false),
                    Obtained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAmps", x => new { x.UserId, x.ItemId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amps");

            migrationBuilder.DropTable(
                name: "UserAmps");
        }
    }
}
