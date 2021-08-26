using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddWishlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserSecondaryWeapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserRoboWeapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserPrimaryWeapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserPets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserMeleeWeapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserFrames",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserArchwings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserArchMeleeWeapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserArchGuns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnWishlist",
                table: "UserAmps",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserSecondaryWeapons");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserRoboWeapons");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserPrimaryWeapons");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserPets");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserMeleeWeapons");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserFrames");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserArchwings");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserArchMeleeWeapons");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserArchGuns");

            migrationBuilder.DropColumn(
                name: "OnWishlist",
                table: "UserAmps");
        }
    }
}
