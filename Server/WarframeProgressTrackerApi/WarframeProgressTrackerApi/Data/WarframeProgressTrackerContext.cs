using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public class WarframeProgressTrackerContext : IdentityDbContext<User> {
        public WarframeProgressTrackerContext(DbContextOptions<WarframeProgressTrackerContext> options) : base(options) { }

        public DbSet<Frame> Frames { get; set; }
        public DbSet<PrimaryWeapon> PrimaryWeapons { get; set; }
        public DbSet<SecondaryWeapon> SecondaryWeapons { get; set; }
        public DbSet<MeleeWeapon> MeleeWeapons { get; set; }
        public DbSet<UserFrame> UserFrames { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<UserFrame>()
                .HasKey(userFrame => new {
                    userFrame.UserId,
                    userFrame.FrameId
                });
            SeedFrames(modelBuilder);
            SeedPrimaryWeapons(modelBuilder);
            SeedSecondaryWeapons(modelBuilder);
            SeedMeleeWeapons(modelBuilder);
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
    }
}
