﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;
using System.Text.Json;
using System.IO;

using static WarframeProgressTrackerApi.Data.SourceLoader;
using static WarframeProgressTrackerApi.Data.BlueprintLoader;

namespace WarframeProgressTrackerApi.Data {
    public class WarframeProgressTrackerContext : IdentityDbContext<User> {
        public WarframeProgressTrackerContext(DbContextOptions<WarframeProgressTrackerContext> options) : base(options) { }

        public DbSet<Frame> Frames { get; set; }
        public DbSet<PrimaryWeapon> PrimaryWeapons { get; set; }
        public DbSet<SecondaryWeapon> SecondaryWeapons { get; set; }
        public DbSet<MeleeWeapon> MeleeWeapons { get; set; }
        public DbSet<AmpPrism> Amps { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<RoboWeapon> RoboWeapons { get; set; }
        public DbSet<Archwing> Archwings { get; set; }
        public DbSet<ArchGun> ArchGuns { get; set; }
        public DbSet<ArchMelee> ArchMeleeWeapons { get; set; }
        public DbSet<Resource> Resources { get; set; }

        public DbSet<UserFrame> UserFrames { get; set; }
        public DbSet<UserPrimaryWeapon> UserPrimaryWeapons { get; set; }
        public DbSet<UserSecondaryWeapon> UserSecondaryWeapons { get; set; }
        public DbSet<UserMeleeWeapon> UserMeleeWeapons { get; set; }
        public DbSet<UserAmp> UserAmps { get; set; }
        public DbSet<UserPet> UserPets { get; set; }
        public DbSet<UserRoboGun> UserRoboWeapons { get; set; }
        public DbSet<UserArchwing> UserArchwings { get; set; }
        public DbSet<UserArchGun> UserArchGuns { get; set; }
        public DbSet<UserArchMelee> UserArchMeleeWeapons { get; set; }
        public DbSet<BlueprintComponent> BlueprintResources { get; set; }
        public DbSet<Source> Sources { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            SetupCompositeKeys(modelBuilder);

            int id = 1;

            id = SeedDataFromCsv<Frame>(modelBuilder, "Warframes", id);
            id = SeedDataFromCsv<PrimaryWeapon>(modelBuilder, "PrimaryWeapons", id);
            id = SeedDataFromCsv<SecondaryWeapon>(modelBuilder, "SecondaryWeapons", id);
            id = SeedDataFromCsv<MeleeWeapon>(modelBuilder, "MeleeWeapons", id);
            id = SeedDataFromCsv<AmpPrism>(modelBuilder, "Amps", id);
            id = SeedDataFromCsv<Pet>(modelBuilder, "Pets", id);
            id = SeedDataFromCsv<RoboWeapon>(modelBuilder, "RoboGuns", id);
            id = SeedDataFromCsv<Archwing>(modelBuilder, "Archwings", id);
            id = SeedDataFromCsv<ArchGun>(modelBuilder, "ArchGuns", id);
            id = SeedDataFromCsv<ArchMelee>(modelBuilder, "ArchMeleeWeapons", id);
            id = SeedDataFromCsv<Resource>(modelBuilder, "Resources", id);

            LoadBlueprints(modelBuilder, this);
            LoadSources(modelBuilder, this);
        }

        public IQueryable<WarframeItem> GetDataSet(string categoryName) {
            switch (categoryName) {
                case "Warframe":
                    return Frames;
                case "PrimaryWeapon":
                case "Primary Weapon":
                    return PrimaryWeapons;
                case "SecondaryWeapon":
                case "Secondary Weapon":
                    return SecondaryWeapons;
                case "MeleeWeapon":
                case "Melee Weapon":
                    return MeleeWeapons;
                case "Amp":
                case "Amp Prism":
                    return Amps;
                case "Pet":
                    return Pets;
                case "RoboGun":
                case "Robo-Gun":
                    return RoboWeapons;
                case "Archwing":
                    return Archwings;
                case "ArchGun":
                case "Archgun":
                    return ArchGuns;
                case "ArchMelee":
                case "Arch-Melee":
                    return ArchMeleeWeapons;
                default: return null;
            }
        }

        private void SetupCompositeKeys(ModelBuilder builder) {
            builder.Entity<UserFrame>().HasKey(item => new { item.UserId, item.ItemId });
            builder.Entity<UserPrimaryWeapon>().HasKey(item => new { item.UserId, item.ItemId });
            builder.Entity<UserSecondaryWeapon>().HasKey(item => new { item.UserId, item.ItemId });
            builder.Entity<UserMeleeWeapon>() .HasKey(item => new { item.UserId, item.ItemId });
            builder.Entity<UserPet>().HasKey(userItem => new { userItem.UserId, userItem.ItemId });
            builder.Entity<UserArchwing>().HasKey(userItem => new { userItem.UserId, userItem.ItemId });
            builder.Entity<UserArchGun>().HasKey(userItem => new {userItem.UserId, userItem.ItemId });
            builder.Entity<UserArchMelee>().HasKey(userItem => new { userItem.UserId, userItem.ItemId });
            builder.Entity<UserRoboGun>().HasKey(userItem => new { userItem.UserId, userItem.ItemId });
            builder.Entity<UserAmp>().HasKey(userAmp => new { userAmp.UserId, userAmp.ItemId });
            builder.Entity<BlueprintComponent>().HasKey(blueprint => new { blueprint.ResultName, blueprint.ComponentName });
        }

        private int SeedDataFromCsv<T>(ModelBuilder builder, string seedFileName, int lastId) 
            where T : WarframeItem {
            var seedData = CsvSeedHelper.GetDataFromSeed<T>(seedFileName, lastId);
            foreach (var item in seedData) {
                builder.Entity<T>().HasData(item);
            }
            return lastId + seedData.Count();
        }
    }
}