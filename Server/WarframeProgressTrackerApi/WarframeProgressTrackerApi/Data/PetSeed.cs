using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public static class PetSeed {
        public static IEnumerable<Pet> Get => new Pet[] {
            new Pet() {
               Id = 1,
               Name = "Huras",
               Category = "Kubrow",

               Health = 75,
               Shield = 125,
               Armor = 50,
               Polarities = "SSV"
            },
            new Pet() {
               Id = 2,
               Name = "Raksa",
               Category = "Kubrow",

               Health = 100,
               Shield = 105,
               Armor = 50,
               Polarities = "SSD"
            },
            new Pet() {
               Id = 3,
               Name = "Sahasa",
               Category = "Kubrow",

               Health = 125,
               Shield = 75,
               Armor = 50,
               Polarities = "SSB"
            },
            new Pet() {
               Id = 4,
               Name = "Sunika",
               Category = "Kubrow",

               Health = 110,
               Shield = 90,
               Armor = 50,
               Polarities = "SSV"
            },
            new Pet() {
               Id = 5,
               Name = "Chesa",
               Category = "Kubrow",

               Health = 125,
               Shield = 75,
               Armor = 50,
               Polarities = "SSD"
            },
            new Pet() {
               Id = 6,
               Name = "Helminth Charger",
               Category = "Kubrow",

               Health = 95,
               Shield = 85,
               Armor = 50,
               Polarities = "SSV"
            },
            new Pet() {
               Id = 7,
               Name = "Vizier Predasite",
               Category = "Kubrow",

               Health = 95,
               Shield = 90,
               Armor = 50,
               Polarities = "S"
            },
            new Pet() {
               Id = 8,
               Name = "Pharaoh Predasite",
               Category = "Kubrow",

               Health = 95,
               Shield = 90,
               Armor = 50,
               Polarities = "S"
            },
            new Pet() {
               Id = 9,
               Name = "Medjay Predasite",
               Category = "Kubrow",

               Health = 95,
               Shield = 90,
               Armor = 50,
               Polarities = "S"
            },

            new Pet() {
               Id = 10,
               Name = "Carrier",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f,
               Armor = 50,
               Polarities = "SSSSD"
            },
            new Pet() {
               Id = 11,
               Name = "Carrier Prime",
               Category = "Sentinel",

               Health = 400,
               Shield = 100,
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f,
               Armor = 150,
               Polarities = "SSSSDV"
            },
            new Pet() {
               Id = 12,
               Name = "Dethcube",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f,
               Armor = 50,
               Polarities = "SSSS"
            },
            new Pet() {
               Id = 13,
               Name = "Dethcube Prime",
               Category = "Sentinel",

               Health = 300,
               Shield = 100,
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f,
               Armor = 150,
               Polarities = "SSSSD"
            },
            new Pet() {
               Id = 14,
               Name = "Diriga",
               Category = "Sentinel",

               Health = 350,
               Shield = 50,
               Armor = 50,
               Polarities = "SSSS",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 14,
               Name = "Djinn",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               Armor = 50,
               Polarities = "SSSSB",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 15,
               Name = "Helios",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               Armor = 50,
               Polarities = "SSSSD",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 16,
               Name = "Helios Prime",
               Category = "Sentinel",
               MasteryRankRequired = 8,

               Health = 250,
               Shield = 100,
               Armor = 100,
               Polarities = "SSSSD",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 17,
               Name = "Nautilus",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               Armor = 50,
               Polarities = "SSSSD",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 18,
               Name = "Oxylus",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               Armor = 50,
               Polarities = "",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 19,
               Name = "Shade",
               Category = "Sentinel",

               Health = 350,
               Shield = 50,
               Armor = 50,
               Polarities = "SSSS",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 20,
               Name = "Prisma Shade",
               Category = "Sentinel",

               Health = 350,
               Shield = 100,
               Armor = 75,
               Polarities = "SSSSB",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 21,
               Name = "Taxon",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               Armor = 50,
               Polarities = "",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 22,
               Name = "Wyrm",
               Category = "Sentinel",

               Health = 200,
               Shield = 100,
               Armor = 50,
               Polarities = "SSSS",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 23,
               Name = "Wyrm Prime",
               Category = "Sentinel",

               Health = 225,
               Shield = 300,
               Armor = 150,
               Polarities = "SSSS",
               HealthMaxFactor = 1.0f,
               ShieldMaxFactor = 1.0f
            },
            new Pet() {
               Id = 24,
               Name = "Para",
               Category = "MOA",

               Health = 0,
               Shield = 0,
               Armor = 0,
               Polarities = ""
            },
            new Pet() {
               Id = 25,
               Name = "Lambeo",
               Category = "MOA",

               Health = 0,
               Shield = 0,
               Armor = 0,
               Polarities = ""
            },
            new Pet() {
               Id = 26,
               Name = "Oloro",
               Category = "MOA",

               Health = 0,
               Shield = 0,
               Armor = 0,
               Polarities = ""
            },
            new Pet() {
               Id = 27,
               Name = "Nychus",
               Category = "MOA",

               Health = 0,
               Shield = 0,
               Armor = 0,
               Polarities = ""
            },
            new Pet() {
               Id = 28,
               Name = "Adarza",
               Category = "Kavat",

               Health = 40,
               Shield = 70,
               Armor = 50,
               Polarities = "SS"
            },
            new Pet() {
               Id = 29,
               Name = "Smeeta",
               Category = "Kavat",

               Health = 50,
               Shield = 60,
               Armor = 50,
               Polarities = "SS"
            },
            new Pet() {
               Id = 30,
               Name = "Vasca",
               Category = "Kavat",

               Health = 80,
               Shield = 70,
               Armor = 50,
               Polarities = "SS"
            },
            new Pet() {
               Id = 31,
               Name = "Venari",
               Category = "Kavat",

               Health = 300,
               Shield = 0,
               Armor = 350,
               Polarities = "SVDB",
               HowToGet = "Khora's special companion"
            },
            new Pet() {
               Id = 32,
               Name = "Sly Vulpaphyla",
               Category = "Kavat",

               Health = 90,
               Shield = 95,
               Armor = 50,
               Polarities = "S"
            },
            new Pet() {
               Id = 33,
               Name = "Crescent Vulpaphyla",
               Category = "Kavat",

               Health = 90,
               Shield = 95,
               Armor = 50,
               Polarities = "S"
            },
            new Pet() {
               Id = 34,
               Name = "Panzer Vulpaphyla",
               Category = "Kavat",

               Health = 90,
               Shield = 95,
               Armor = 50,
               Polarities = "S"
            }
        };
    }
}