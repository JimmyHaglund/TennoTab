using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;
using System.IO;
using System.Reflection;
using System.Text;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace WarframeProgressTrackerApi.Data {
    public static class PrimaryWeaponSeed {
        public static IEnumerable<PrimaryWeapon> Get(int startId) {
            var id = startId;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "WarframeProgressTrackerApi.Data.Seed.PrimaryWeapons.csv";

            var results = CsvSeedHelper.ReadFromCsv<PrimaryWeapon>(assembly, resourceName);
            foreach (var result in results)
                result.Id = ++id;
            return results;
        }
    }
}