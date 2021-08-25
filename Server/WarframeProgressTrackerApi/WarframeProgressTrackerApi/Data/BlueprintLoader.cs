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
        public class BlueprintSeedModel {
            public string ResultName { get; set; }
            public string ResultCategory { get; set; }
            public string ResourceName { get; set; }
            public string ResourceCategory { get; set; }
            public int Amount { get; set; }
        }

        public static void LoadBlueprints(ModelBuilder builder, WarframeProgressTrackerContext context) {
            var assembly = Assembly.GetExecutingAssembly();
            var fileName = GetSeedResourceName("Blueprints");
            var blueprintSeed = CsvSeedHelper.ReadFromCsv<BlueprintSeedModel>(assembly, fileName);
            foreach (var seedRow in blueprintSeed) {
                var resultSet = context.GetDataSet(seedRow.ResultCategory);
                var resourceSet = context.GetDataSet(seedRow.ResultCategory);
                var result = resultSet
                    .Where(result => result.Name == seedRow.ResultName)
                    .FirstOrDefault();
                var resource = resourceSet
                    .Where(resource => resource.Name == seedRow.ResourceName)
                    .FirstOrDefault();

                if (result == null) {
                    var message = "Load Blueprints error: Result named " + seedRow.ResultName
                       + " could not be found in category " + seedRow.ResultCategory;
                    throw new Exception(message);
                }
                if (resource == null) {
                    var message = "Load Blueprints error: Resource named " + seedRow.ResourceName
                       + " could not be found in category " + seedRow.ResourceCategory;
                    throw new Exception(message);
                }

                var blueprint = new BlueprintResource() {
                    ResultId = result.Id,
                    ResultCategory = seedRow.ResultCategory,
                    ComponentId = resource.Id,
                    ComponentCategory = seedRow.ResourceCategory,
                    ComponentCount = seedRow.Amount
                };

                builder.Entity<BlueprintResource>().HasData(blueprint);
            }
        }

        private static string GetSeedResourceName(string seedFileName) {
            return "WarframeProgressTrackerApi.Data.Seed." + seedFileName + ".csv";
        }
    }
}
