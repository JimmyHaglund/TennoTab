using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;
using System.Reflection;


namespace WarframeProgressTrackerApi.Data {
    public class BlueprintLoader {
        public static void LoadBlueprints(ModelBuilder builder, WarframeProgressTrackerContext context) {
            var assembly = Assembly.GetExecutingAssembly();
            var fileName = GetSeedResourceName("Blueprints");
            var blueprintSeed = CsvSeedHelper.ReadFromCsv<BlueprintResource>(assembly, fileName);
            foreach (var seedRow in blueprintSeed) {
                builder.Entity<BlueprintResource>().HasData(seedRow);
            }
        }

        private static string GetSeedResourceName(string seedFileName) {
            return "WarframeProgressTrackerApi.Data.Seed." + seedFileName + ".csv";
        }
    }
}
