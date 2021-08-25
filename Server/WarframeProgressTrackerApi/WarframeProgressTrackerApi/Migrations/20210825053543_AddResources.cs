using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class AddResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlueprintResources_Resources_ResourceId",
                table: "BlueprintResources");

            migrationBuilder.DropIndex(
                name: "IX_BlueprintResources_ResourceId",
                table: "BlueprintResources");

            migrationBuilder.DropColumn(
                name: "ResourceId",
                table: "BlueprintResources");

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 487, "Adramal Alloy" },
                    { 559, "Dusklight Sarracenia" },
                    { 558, "Diluted Thermia" },
                    { 557, "Devolved Namalon" },
                    { 556, "Devar" },
                    { 555, "Detonite Injector" },
                    { 554, "Detonite Ampule" },
                    { 553, "Dentrite Blastoma" },
                    { 552, "Delta Beacon" },
                    { 551, "Delicate Pobber Tag" },
                    { 550, "Damaged Necramech Weapon Stock" },
                    { 549, "Damaged Necramech Weapon Receiver" },
                    { 548, "Damaged Necramech Weapon Pod" },
                    { 547, "Damaged Necramech Weapon Barrel" },
                    { 546, "Damaged Necranech Pod" },
                    { 545, "Damaged Necramech Engine" },
                    { 544, "Damaged Necramech Casing" },
                    { 543, "Dagonic" },
                    { 542, "Cuthol Tendrils" },
                    { 541, "Cubic Diodes" },
                    { 540, "Cryptographic Alu" },
                    { 539, "Cryotic" },
                    { 560, "Dusky-Headed Virmink Tag" },
                    { 538, "Crisma Toroid" },
                    { 561, "Echowinder Anoscopic Sensor" },
                    { 563, "Esher Devar" },
                    { 584, "Goopolla Spleen" },
                    { 583, "Goblite Tears" },
                    { 582, "Goblite" },
                    { 581, "Ganglion" },
                    { 580, "Gamma Beacon" },
                    { 579, "Gallos Rods" },
                    { 578, "Gallium" },
                    { 577, "Frostleaf" },
                    { 576, "Frostcap" },
                    { 575, "Fresnels" },
                    { 574, "Fish Scales" },
                    { 573, "Fish Oil" },
                    { 572, "Fish Meat" },
                    { 571, "Fieldron Sample" },
                    { 570, "Fieldron" },
                    { 569, "Fersteel Alloy" },
                    { 568, "Ferros" },
                    { 567, "Ferrite" },
                    { 566, "Ferment Bladder" },
                    { 565, "Faceted Tiametrite" },
                    { 564, "Eye-Eye Rotoblade" },
                    { 562, "Embolos" },
                    { 537, "Crimzian" },
                    { 536, "Crescent Vulpaphyla Tag" },
                    { 535, "Cranial Foremount" },
                    { 508, "Bonewidow Capsule" },
                    { 507, "Black-Banded Bolarola Tag" },
                    { 506, "Biotic Filter" },
                    { 505, "Beta Corruptor" },
                    { 504, "Benign Infested Tumor" },
                    { 503, "Bapholite" },
                    { 502, "Azurite" },
                    { 501, "Axidrol Alloy" },
                    { 500, "Axidite" },
                    { 499, "Auroxium Alloy" },
                    { 498, "Auron" },
                    { 497, "Aucrux Capacitors" },
                    { 496, "Atmo Systems" },
                    { 495, "Asterite" },
                    { 494, "Argon Crystal" },
                    { 493, "Antiserum Injector Fragment" },
                    { 492, "Anomaly Shard" },
                    { 491, "Amarast" },
                    { 490, "Alpha Corruptor" },
                    { 489, "Alloy Plate" },
                    { 488, "Adramalium" },
                    { 509, "Bonewidow Casing" },
                    { 510, "Bonewidow Engine" },
                    { 511, "Bonewidow Weapon Pod" },
                    { 512, "Bracoid" },
                    { 534, "Cortege Stock" },
                    { 533, "Cortege Receiver" },
                    { 532, "Cortege Barrel" },
                    { 531, "Coprun" },
                    { 530, "Coprite Alloy" },
                    { 529, "Copernics" },
                    { 528, "Control Module" },
                    { 527, "Condroc Wing" },
                    { 526, "Common Avichaea Tag" },
                    { 525, "Circuits" },
                    { 585, "Gorgaricus Spore" },
                    { 524, "Charc Electroplax" },
                    { 522, "Cetus Wisp" },
                    { 521, "Cerulean Fungus Extract" },
                    { 520, "Caustic Cryptilex Tag" },
                    { 519, "Carbides" },
                    { 518, "Calda Toroid" },
                    { 517, "Cabrochon Embolos" },
                    { 516, "Burrowing Cryptilex Tag" },
                    { 515, "Brindle Kubrodon Tag" },
                    { 514, "Brickie Muon Battery" },
                    { 513, "Breath of the Eidolon" },
                    { 523, "Charmote Sagan Module" },
                    { 586, "Green Velocipod Tag" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.AddColumn<int>(
                name: "ResourceId",
                table: "BlueprintResources",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintResources_ResourceId",
                table: "BlueprintResources",
                column: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlueprintResources_Resources_ResourceId",
                table: "BlueprintResources",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
