using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public static class ArchwingSeed {
        public static IEnumerable<Archwing> Get => new Archwing[] {
            new Archwing() {
                Id = 1,
                Name = "Amesha",

                Health = 400,
                Shield = 200,
                Armor = 200,
                Energy = 200,

                FlightSpeed = 1.1f,
                Polarities = "BDV"
            },
            new Archwing() {
                Id = 2,
                Name = "Elytron",

                Health = 450,
                Shield = 450,
                Armor = 150,
                Energy = 125,

                FlightSpeed = 0.9f,
                Polarities = "VV"
            },
            new Archwing() {
                Id = 3,
                Name = "Itzal",

                Health = 200,
                Shield = 200,
                Armor = 50,
                Energy = 200,

                FlightSpeed = 1.2f,
                Polarities = "VDB"
            },
            new Archwing() {
                Id = 4,
                Name = "Odonata",

                Health = 300,
                Shield = 300,
                Armor = 100,
                Energy = 100,

                FlightSpeed = 1.0f,
                Polarities = "VDB"
            },
            new Archwing() {
                Id = 5,
                Name = "Odonata Prime",

                Health = 400,
                Shield = 400,
                Armor = 100,
                Energy = 100,

                FlightSpeed = 1.05f,
                Polarities = "VDBB"
            }
        };
    }
}
