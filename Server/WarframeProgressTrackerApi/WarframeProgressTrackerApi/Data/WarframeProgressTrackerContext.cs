using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;
using System.Text.Json;
using System.IO;

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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            SetupCompositeKeys(modelBuilder);

            SeedFrames(modelBuilder);
            SeedPrimaryWeapons(modelBuilder);
            SeedSecondaryWeapons(modelBuilder);
            SeedMeleeWeapons(modelBuilder);
            SeedPets(modelBuilder);
            SeedArchwings(modelBuilder);
            SeedArchGuns(modelBuilder);
            SeedArchMeleeWeapons(modelBuilder);
            SeedRoboWeapons(modelBuilder);
            SeedAmps(modelBuilder);
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
        }

        private void SeedFrames(ModelBuilder builder) {
            foreach (var frame in FrameSeed.Get) {
                builder.Entity<Frame>().HasData(frame);
            }
        }

        private void SeedPrimaryWeapons(ModelBuilder builder) {
            foreach (var primaryWeapon in PrimaryWeaponSeed.Get) {
                builder.Entity<PrimaryWeapon>().HasData(primaryWeapon);
            }
        }

        private void SeedSecondaryWeapons(ModelBuilder builder) {
            foreach (var secondaryWeapon in SecondaryWeaponSeed.Get) {
                builder.Entity<SecondaryWeapon>().HasData(secondaryWeapon);
            }
        }

        private void SeedMeleeWeapons(ModelBuilder builder) {
            foreach (var meleeWeapon in MeleeWeaponSeed.Get) {
                builder.Entity<MeleeWeapon>().HasData(meleeWeapon);
            }
        }

        private void SeedPets(ModelBuilder builder) {
            foreach(var pet in PetSeed.Get) {
                builder.Entity<Pet>().HasData(pet);
            }
        }

        private void SeedArchwings(ModelBuilder builder) {
            foreach (var archwing in ArchwingSeed.Get) {
                builder.Entity<Archwing>().HasData(archwing);
            }
        }

        private void SeedArchGuns(ModelBuilder builder) {
            foreach (var archGun in ArchGunSeed.Get) {
                builder.Entity<ArchGun>().HasData(archGun);
            }
        }

        private void SeedArchMeleeWeapons(ModelBuilder builder) {
            foreach (var archMelee in ArchMeleeSeed.Get) {
                builder.Entity<ArchMelee>().HasData(archMelee);
            }
        }

        private void SeedRoboWeapons(ModelBuilder builder) {
            foreach (var roboWeapon in RoboWeaponSeed.Get) {
                builder.Entity<RoboWeapon>().HasData(roboWeapon);
            }
        }

        private void SeedAmps(ModelBuilder builder) {
            foreach (var amp in AmpSeed.Get) {
                builder.Entity<AmpPrism>().HasData(amp);
            }
        }
    }
}