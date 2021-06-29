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

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            SeedFrames(modelBuilder);
        }

        private void SeedFrames(ModelBuilder builder) {
            foreach(var frame in SeededFrames) {
                builder.Entity<Frame>().HasData(frame);
            }
        }

        private IEnumerable<Frame> SeededFrames => new List<Frame>() {
            new Frame() {
                Id = 1,
                Name = "Excalibur",
                Health = 110,
                Shield = 50,
                Armor = 100,
                Energy = 100,
                SprintSpeed = 1,
                Polarities = "UAF",
                ExilusPolarity = "E",
                AuraPolarity = "A",
                SubsumedAbility = 0
            }
        };
    }
}
