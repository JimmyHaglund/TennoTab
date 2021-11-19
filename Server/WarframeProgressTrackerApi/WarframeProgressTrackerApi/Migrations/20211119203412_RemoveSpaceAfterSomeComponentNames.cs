using Microsoft.EntityFrameworkCore.Migrations;

namespace WarframeProgressTrackerApi.Migrations
{
    public partial class RemoveSpaceAfterSomeComponentNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis ", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics ", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis ", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis ", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics ", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics ", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems ", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems ", "Orokin Cell" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems ", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis ", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics ", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis ", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis ", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics ", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems ", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems ", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis ", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics ", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems ", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis ", "Hespazym Alloy" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis ", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis ", "Vega Toroid" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics ", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics ", "Hespazym Alloy" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics ", "Sola Toroid" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems ", "Calda Toroid" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems ", "Entroplasma" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems ", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis ", "Heart Nyth" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis ", "Radian Sentirum" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis ", "Star Crimzian" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics ", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems ", "Marquise Thyst" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems ", "Mytocardia Spore" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems ", "Radiant Zodian" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis ", "Forest Rodent Spine" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis ", "Icon Condroc Wing" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis ", "Tralok Eyes" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics ", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems ", "Icon Fish Meat" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis ", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics ", "Titanium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics ", "Trapezium Xenorhast" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems ", "Cabochon Embolos" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems ", "Hexenon" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems ", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis ", "Plastids" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis ", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems ", "Neurodes" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems ", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis ", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics ", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems ", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems ", "Orokin Cell" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems ", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis ", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis ", "Nullstones" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics ", "Titanium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems ", "Asterite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis ", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis ", "Venerdo Alloy" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics ", "Plastids" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics ", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems ", "Exa Brain" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems ", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis ", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis ", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics ", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics ", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis ", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis ", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis ", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics ", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics ", "Plastids" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems ", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems ", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems ", "Neurodes" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems ", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems ", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems ", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems ", "Polymer Bundle" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems", "Gallium", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems", "Polymer Bundle", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics", "Cryotic", 600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics", "Circuits", 1100 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis", "Plastids", 450 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis", "Polymer Bundle", 1425 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems", "Neurodes", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems", "Rubedo", 1250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics", "Neural Sensors", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics", "Oxium", 250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics", "Plastids", 350 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems", "Orokin Cell", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis", "Rubedo", 300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis", "Polymer Bundle", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems", "Oxium", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems", "Polymer Bundle", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics", "Plastids", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics", "Salvage", 875 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis", "Ferrite", 3600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis", "Venerdo Alloy", 20 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems", "Cryotic", 350 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems", "Exa Brain", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics", "Alloy Plate", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics", "Polymer Bundle", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis", "Gallium", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis", "Circuits", 350 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis", "Rubedo", 50 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems", "Neurodes", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics", "Neural Sensors", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics", "Alloy Plate", 6000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics", "Circuits", 1500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis", "Morphics", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis", "Cryotic", 1500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis", "Rubedo", 2000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems", "Control Module", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems", "Oxium", 300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics", "Neural Sensors", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics", "Cryotic", 525 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics", "Salvage", 4700 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis", "Rubedo", 725 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems", "Ferrite", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems", "Orokin Cell", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems", "Control Module", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems", "Cryotic", 550 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics", "Neural Sensors", 8 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics", "Control Module", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics", "Oxium", 250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis", "Morphics", 8 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis", "Rubedo", 1200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems", "Circuits", 875 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics", "Alloy Plate", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics", "Neural Sensors", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics", "Salvage", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis", "Gallium", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis", "Nano Spores", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis", "Rubedo", 400 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems", "Cryotic", 370 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis", "Nano Spores", 900 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis", "Oxium", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics", "Circuits", 800 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis", "Nano Spores", 1800 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis", "Cryotic", 1300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis", "Rubedo", 700 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems", "Ferrite", 4600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems", "Polymer Bundle", 1700 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems", "Morphics", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics", "Circuits", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics", "Neural Sensors", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics", "Polymer Bundle", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis", "Ferrite", 900 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis", "Rubedo", 50 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems", "Salvage", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics", "Alloy Plate", 1100 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics", "Polymer Bundle", 1400 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems", "Entroplasma", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics", "Argon Crystal", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics", "Rubedo", 1600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics", "Salvage", 6200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis", "Radian Sentirum", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis", "Heart Nyth", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis", "Star Crimzian", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems", "Radiant Zodian", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems", "Marquise Thyst", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems", "Mytocardia Spore", 70 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics", "Sola Toroid", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics", "Alloy Plate", 2850 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics", "Hespazym Alloy", 50 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis", "Vega Toroid", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis", "Salvage", 3250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis", "Hespazym Alloy", 100 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems", "Calda Toroid", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems", "Ferrite", 2500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics", "Trapezium Xenorhast", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics", "Titanium", 2000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics", "Oxium", 750 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis", "Ferrite", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis", "Rubedo", 300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems", "Salvage", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics", "Control Module", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics", "Ferrite", 3500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis", "Forest Rodent Spine", 30 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis", "Tralok Eyes", 20 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems", "Circuits", 1125 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems", "Morphics", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems", "Icon Fish Meat", 125 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics", "Circuits", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics", "Oxium", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics", "Polymer Bundle", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis", "Icon Condroc Wing", 25 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems", "Gallium", 4 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics", "Neural Sensors", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis", "Nitain Extract", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis", "Cryotic", 1500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems", "Cabochon Embolos", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems", "Nano Spores", 5500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems", "Hexenon", 550 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics", "Neural Sensors", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics", "Polymer Bundle", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics", "Titanium", 1200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis", "Morphics", 8 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis", "Cryotic", 650 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis", "Nullstones", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems", "Oxium", 250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems", "Asterite", 15 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics", "Alloy Plate", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics", "Rubedo", 750 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems", "Polymer Bundle", 1200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Neuroptics", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Neuroptics", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Prime Systems", "Orokin Cell" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Ash Systems", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Neuroptics", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Chassis", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Neuroptics", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Prime Systems", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Atlas Systems", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Neuroptics", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Prime Systems", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Banshee Systems", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis", "Hespazym Alloy" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Chassis", "Vega Toroid" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics", "Hespazym Alloy" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Neuroptics", "Sola Toroid" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems", "Calda Toroid" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems", "Entroplasma" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Baruuk Systems", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis", "Heart Nyth" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis", "Radian Sentirum" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Chassis", "Star Crimzian" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Neuroptics", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems", "Marquise Thyst" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems", "Mytocardia Spore" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Gauss Systems", "Radiant Zodian" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis", "Forest Rodent Spine" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis", "Icon Condroc Wing" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Chassis", "Tralok Eyes" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Neuroptics", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems", "Icon Fish Meat" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Grendel Systems", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Chassis", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics", "Titanium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Neuroptics", "Trapezium Xenorhast" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems", "Cabochon Embolos" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems", "Hexenon" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Lavos Systems", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis", "Plastids" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Chassis", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Neuroptics", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems", "Neurodes" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Nidus Prime Systems", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics", "Alloy Plate" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Neuroptics", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems", "Gallium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems", "Orokin Cell" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Oberon Systems", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Neuroptics", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Octavia Prime Systems", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis", "Morphics" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Chassis", "Nullstones" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Neuroptics", "Titanium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems", "Asterite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Sevagoth Systems", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Chassis", "Venerdo Alloy" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics", "Plastids" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Neuroptics", "Salvage" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems", "Exa Brain" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Yareli Systems", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis", "Nano Spores" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Chassis", "Rubedo" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics", "Circuits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Neuroptics", "Polymer Bundle" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis", "Ferrite" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis", "Nitain Extract" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Chassis", "Tellurium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics", "Neural Sensors" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Neuroptics", "Plastids" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems", "Argon Crystal" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems", "Cryotic" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Prime Systems", "Neurodes" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems", "Control Module" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems", "Credits" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems", "Oxium" });

            migrationBuilder.DeleteData(
                table: "BlueprintResources",
                keyColumns: new[] { "ItemName", "ComponentName" },
                keyValues: new object[] { "Zephyr Systems", "Polymer Bundle" });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems ", "Gallium", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems ", "Polymer Bundle", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics ", "Cryotic", 600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Neuroptics ", "Circuits", 1100 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis ", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis ", "Plastids", 450 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Chassis ", "Polymer Bundle", 1425 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems ", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems ", "Neurodes", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Nidus Prime Systems ", "Rubedo", 1250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics ", "Neural Sensors", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics ", "Oxium", 250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Neuroptics ", "Plastids", 350 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis ", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis ", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems ", "Orokin Cell", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis ", "Rubedo", 300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis ", "Polymer Bundle", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems ", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems ", "Oxium", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Systems ", "Polymer Bundle", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics ", "Plastids", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Neuroptics ", "Salvage", 875 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis ", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Chassis ", "Ferrite", 3600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis ", "Venerdo Alloy", 20 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems ", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems ", "Cryotic", 350 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Systems ", "Exa Brain", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics ", "Alloy Plate", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics ", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Neuroptics ", "Polymer Bundle", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Oberon Chassis ", "Gallium", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Yareli Chassis ", "Circuits", 350 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis ", "Rubedo", 50 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems ", "Neurodes", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics ", "Neural Sensors", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics ", "Alloy Plate", 6000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics ", "Circuits", 1500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis ", "Morphics", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis ", "Cryotic", 1500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Chassis ", "Rubedo", 2000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems ", "Control Module", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Systems ", "Oxium", 300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics ", "Neural Sensors", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics ", "Cryotic", 525 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Neuroptics ", "Salvage", 4700 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis ", "Tellurium", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis ", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Chassis ", "Rubedo", 725 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Prime Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems ", "Ferrite", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems ", "Orokin Cell", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems ", "Control Module", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems ", "Cryotic", 550 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics ", "Neural Sensors", 8 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics ", "Control Module", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Neuroptics ", "Oxium", 250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis ", "Morphics", 8 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Chassis ", "Rubedo", 1200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Prime Systems ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems ", "Nitain Extract", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems ", "Circuits", 875 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics ", "Alloy Plate", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics ", "Neural Sensors", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Neuroptics ", "Salvage", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis ", "Gallium", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis ", "Nano Spores", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Chassis ", "Rubedo", 400 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Prime Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Octavia Prime Systems ", "Cryotic", 370 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis ", "Nano Spores", 900 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis ", "Oxium", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics ", "Circuits", 800 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis ", "Nano Spores", 1800 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis ", "Cryotic", 1300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Chassis ", "Rubedo", 700 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems ", "Ferrite", 4600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems ", "Polymer Bundle", 1700 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Systems ", "Morphics", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics ", "Circuits", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics ", "Neural Sensors", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Neuroptics ", "Polymer Bundle", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis ", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis ", "Ferrite", 900 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Chassis ", "Rubedo", 50 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems ", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems ", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Banshee Systems ", "Salvage", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics ", "Alloy Plate", 1100 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics ", "Polymer Bundle", 1400 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems ", "Entroplasma", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics ", "Argon Crystal", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics ", "Rubedo", 1600 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Neuroptics ", "Salvage", 6200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis ", "Radian Sentirum", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis ", "Heart Nyth", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Chassis ", "Star Crimzian", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems ", "Radiant Zodian", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems ", "Marquise Thyst", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Gauss Systems ", "Mytocardia Spore", 70 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics ", "Sola Toroid", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics ", "Alloy Plate", 2850 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics ", "Hespazym Alloy", 50 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis ", "Vega Toroid", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis ", "Salvage", 3250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Chassis ", "Hespazym Alloy", 100 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems ", "Calda Toroid", 3 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Systems ", "Ferrite", 2500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Baruuk Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics ", "Trapezium Xenorhast", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics ", "Titanium", 2000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Neuroptics ", "Oxium", 750 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis ", "Ferrite", 1000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis ", "Rubedo", 300 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems ", "Control Module", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems ", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Systems ", "Salvage", 500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics ", "Control Module", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Neuroptics ", "Ferrite", 3500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis ", "Morphics", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis ", "Forest Rodent Spine", 30 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis ", "Tralok Eyes", 20 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems ", "Circuits", 1125 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems ", "Morphics", 10 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Systems ", "Icon Fish Meat", 125 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics ", "Circuits", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics ", "Oxium", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Zephyr Neuroptics ", "Polymer Bundle", 200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Grendel Chassis ", "Icon Condroc Wing", 25 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems ", "Gallium", 4 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics ", "Neural Sensors", 1 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis ", "Nitain Extract", 5 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Chassis ", "Cryotic", 1500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems ", "Cabochon Embolos", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems ", "Nano Spores", 5500 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Lavos Systems ", "Hexenon", 550 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics ", "Neural Sensors", 6 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics ", "Polymer Bundle", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics ", "Titanium", 1200 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis ", "Morphics", 8 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis ", "Cryotic", 650 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Chassis ", "Nullstones", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems ", "Argon Crystal", 2 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems ", "Oxium", 250 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Systems ", "Asterite", 15 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics ", "Credits", 15000 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Ash Neuroptics ", "Alloy Plate", 150 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Sevagoth Neuroptics ", "Rubedo", 750 });

            migrationBuilder.InsertData(
                table: "BlueprintResources",
                columns: new[] { "ItemName", "ComponentName", "ComponentAmount" },
                values: new object[] { "Atlas Prime Systems ", "Polymer Bundle", 1200 });
        }
    }
}
