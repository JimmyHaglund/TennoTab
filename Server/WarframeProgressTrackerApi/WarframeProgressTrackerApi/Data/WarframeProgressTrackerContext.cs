using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public class WarframeProgressTrackerContext : DbContext {
        public WarframeProgressTrackerContext(DbContextOptions<WarframeProgressTrackerContext> options) : base(options) { }

        public DbSet<Frame> Frames { get; set; }
        public DbSet<PrimaryWeapon> PrimaryWeapons { get; set; }
        public DbSet<SecondaryWeapon> SecondaryWeapons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            SeedFrames(modelBuilder);
            SeedPrimaryWeapons(modelBuilder);
            SeedSecondaryWeapons(modelBuilder);
        }

        private void SeedFrames(ModelBuilder builder) {
            foreach(var frame in SeededFrames) {
                builder.Entity<Frame>().HasData(frame);
            }
        }

        private void SeedPrimaryWeapons(ModelBuilder builder) {
            foreach(var primaryWeapon in PrimaryWeaponSeed.Get) {
                builder.Entity<PrimaryWeapon>().HasData(primaryWeapon);
            }
        }

        private void SeedSecondaryWeapons(ModelBuilder builder) {
            foreach(var secondaryWeapon in SecondaryWeaponSeed.Get) {
                builder.Entity<SecondaryWeapon>().HasData(secondaryWeapon);
            }
        }

        private IEnumerable<Frame> SeededFrames => new List<Frame>() {
            new Frame() {
                Id = 1,
                MasteryRankRequired = 0,
                Name = "Excalibur",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 225,
                Energy = 100,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1,
                Polarities = "DV",
                ExilusPolarity = "",
                AuraPolarity = "",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 2,
                MasteryRankRequired = 0,
                Name = "Ash",
                Health = 150,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 100,
                Energy = 100,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.15f,
                Polarities = "VV",
                ExilusPolarity = "",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 3,
                MasteryRankRequired = 0,
                Name = "Atlas",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 450,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 0.9f,
                Polarities = "BDV",
                ExilusPolarity = "",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 4,
                MasteryRankRequired = 0,
                Name = "Banshee",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 100,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.1f,
                Polarities = "VV",
                ExilusPolarity = "",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 5,
                MasteryRankRequired = 0,
                Name = "Baruuk",
                Health = 75,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 175,
                Energy = 200,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.2f,
                Polarities = "DD",
                ExilusPolarity = "B",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 6,
                MasteryRankRequired = 0,
                Name = "Chroma",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 350,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.0f,
                Polarities = "BV",
                ExilusPolarity = "",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 7,
                MasteryRankRequired = 0,
                Name = "Ember",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 125,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.1f,
                Polarities = "BB",
                ExilusPolarity = "",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 8,
                MasteryRankRequired = 0,
                Name = "Equinox",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 125,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.15f,
                Polarities = "DV",
                ExilusPolarity = "",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 9,
                MasteryRankRequired = 0,
                Name = "Frost",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 150,
                ShieldMaxFactor = 3.0f,
                Armor = 300,
                Energy = 100,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 0.9f,
                Polarities = "BD",
                ExilusPolarity = "",
                AuraPolarity = "D",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 10,
                MasteryRankRequired = 0,
                Name = "Gara",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 150,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.15f,
                Polarities = "VV",
                ExilusPolarity = "",
                AuraPolarity = "D",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 11,
                MasteryRankRequired = 0,
                Name = "Garuda",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 300,
                Energy = 120,
                EnergyMaxFactor = 2.25f,
                SprintSpeed = 1.0f,
                Polarities = "BD",
                ExilusPolarity = "",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 12,
                MasteryRankRequired = 0,
                Name = "Gauss",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 150,
                ShieldMaxFactor = 3.0f,
                Armor = 175,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.4f,
                Polarities = "VD",
                ExilusPolarity = "B",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 13,
                MasteryRankRequired = 0,
                Name = "Grendel",
                Health = 350,
                HealthMaxFactor = 3.0f,
                Shield = 25,
                ShieldMaxFactor = 3.0f,
                Armor = 350,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 0.95f,
                Polarities = "BDD",
                ExilusPolarity = "",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 14,
                MasteryRankRequired = 0,
                Name = "Harrow",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 150,
                ShieldMaxFactor = 3.0f,
                Armor = 175,
                Energy = 100,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.0f,
                Polarities = "DB",
                ExilusPolarity = "",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 15,
                MasteryRankRequired = 0,
                Name = "Hildryn",
                Health = 75,
                HealthMaxFactor = 3.0f,
                Shield = 450,
                ShieldMaxFactor = 3.5f,
                Armor = 100,
                Energy = 0,
                EnergyMaxFactor = 0.0f,
                SprintSpeed = 1.0f,
                Polarities = "DD",
                ExilusPolarity = "D",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 16,
                MasteryRankRequired = 0,
                Name = "Hydroid",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 125,
                ShieldMaxFactor = 3.0f,
                Armor = 225,
                Energy = 125,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.05f,
                Polarities = "VB",
                ExilusPolarity = "",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 17,
                MasteryRankRequired = 0,
                Name = "Inaros",
                Health = 550,
                HealthMaxFactor = 4.0f,
                Shield = 0,
                ShieldMaxFactor = 0.0f,
                Armor = 225,
                Energy = 100,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.0f,
                Polarities = "DD",
                ExilusPolarity = "B",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 18,
                MasteryRankRequired = 0,
                Name = "Ivara",
                Health = 75,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 100,
                Energy = 175,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.15f,
                Polarities = "DB",
                ExilusPolarity = "",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 19,
                MasteryRankRequired = 0,
                Name = "Khora",
                Health = 125,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 275,
                Energy = 125,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.05f,
                Polarities = "VB",
                ExilusPolarity = "B",
                AuraPolarity = "D",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 20,
                MasteryRankRequired = 0,
                Name = "Lavos",
                Health = 200,
                HealthMaxFactor = 3.0f,
                Shield = 100,
                ShieldMaxFactor = 3.0f,
                Armor = 450,
                ArmorMaxFactor = 1.5f,
                Energy = 0,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.15f,
                Polarities = "DB",
                ExilusPolarity = "",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 21,
                MasteryRankRequired = 0,
                Name = "Limbo",
                Health = 100,
                HealthMaxFactor = 3.0f,
                Shield = 75,
                ShieldMaxFactor = 3.0f,
                Armor = 100,
                Energy = 150,
                EnergyMaxFactor = 1.5f,
                SprintSpeed = 1.15f,
                Polarities = "VV",
                ExilusPolarity = "",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 22,
                MasteryRankRequired = 0,
                Name = "Loki",
                Health = 75,
                Shield = 75,
                Armor = 100,
                Energy = 100,
                SprintSpeed = 1.25f,
                Polarities = "DV",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 23,
                MasteryRankRequired = 0,
                Name = "Mag",
                Health = 75,
                Shield = 150,
                Armor = 100,
                Energy = 125,
                SprintSpeed = 1.25f,
                Polarities = "BB",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 24,
                MasteryRankRequired = 0,
                Name = "Mesa",
                Health = 125,
                Shield = 75,
                Armor = 100,
                Energy = 100,
                SprintSpeed = 1.1f,
                Polarities = "BB",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 25,
                MasteryRankRequired = 0,
                Name = "Mirage",
                Health = 80,
                Shield = 80,
                Armor = 100,
                Energy = 150,
                SprintSpeed = 1.2f,
                Polarities = "DV",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 26,
                Name = "Nekros",
                Health = 100,
                Shield = 90,
                Armor = 100,
                Energy = 100,
                SprintSpeed = 1.1f,
                Polarities = "BV",
                AuraPolarity = "",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 27,
                Name = "Nezha",
                Health = 125,
                Shield = 50,
                Armor = 190,
                Energy = 150,
                SprintSpeed = 1.15f,
                Polarities = "DV",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 28,
                Name = "Nidus",
                Health = 150,
                Shield = 0,
                Armor = 300,
                ArmorMaxFactor = 1.5f,
                Energy = 100,
                SprintSpeed = 1.0f,
                Polarities = "VD",
                AuraPolarity = "V",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 29,
                Name = "Nova",
                Health = 100,
                Shield = 75,
                Armor = 100,
                Energy = 150,
                SprintSpeed = 1.2f,
                Polarities = "VV",
                AuraPolarity = "B",
                SubsumedAbility = 0
            },
            new Frame() {
                Id = 30,
                Name = "Nyx",
                Health = 100,
                Shield = 100,
                Armor = 100,
                Energy = 150,
                SprintSpeed = 1.1f,
                Polarities = "VB",
                AuraPolarity = "B",
                SubsumedAbility = 0
            }
        };
    }
}
