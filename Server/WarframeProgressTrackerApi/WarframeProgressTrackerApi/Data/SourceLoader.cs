using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;
using System.Reflection;

namespace WarframeProgressTrackerApi.Data {
    public static class SourceLoader {
        public static void LoadSources(ModelBuilder builder, WarframeProgressTrackerContext context) {
            var assembly = Assembly.GetExecutingAssembly();
            var fileName = GetSeedResourceName("Sources");
            var seed = CsvSeedHelper.ReadFromCsv<Source>(assembly, fileName);
            var id = 0;
            foreach (var row in seed) {
                row.Id = ++id;
                builder.Entity<Source>().HasData(row);
            }
        }

        private static string GetSeedResourceName(string seedFileName) {
            return "WarframeProgressTrackerApi.Data.Seed." + seedFileName + ".csv";
        }
    }
}
