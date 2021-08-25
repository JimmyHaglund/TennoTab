using System.IO;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public static class CsvSeedHelper {
        public static ICollection<DataType> GetDataFromSeed<DataType>(string seedFileName, int lastId) 
            where DataType : WarframeItem {
            var id = lastId;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = GetSeedResourceName(seedFileName);
            var results = ReadFromCsv<DataType>(assembly, resourceName);
            
            foreach (var result in results) result.Id = ++id;
            return results;
        }

        private static string GetSeedResourceName(string seedFileName) {
            return "WarframeProgressTrackerApi.Data.Seed." + seedFileName + ".csv";
        }

        public static ICollection<DataType> ReadFromCsv<DataType>(
            Assembly assembly, string resourceName) {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture) {
                HeaderValidated = null,
                MissingFieldFound = null
            };
            using (var stream = assembly.GetManifestResourceStream(resourceName)) {
                using (var streamReader = new StreamReader(stream, Encoding.UTF8)) {
                    using (var csvReader = new CsvReader(streamReader, configuration)) {
                        var result = csvReader.GetRecords<DataType>().ToList();
                        return result.ToList();
                    }
                }
            }
        }
    }
}
