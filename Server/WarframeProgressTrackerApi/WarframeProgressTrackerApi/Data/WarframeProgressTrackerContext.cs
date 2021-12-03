using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Data {
    public class WarframeProgressTrackerContext : IdentityDbContext<User> {
        public WarframeProgressTrackerContext(DbContextOptions<WarframeProgressTrackerContext> options) : base(options) { }

        public DbSet<AssassinationMissionReward> AssassinationMissionRewards { get; set; }
        public DbSet<BaroKiteerProduct> BaroKiteerProducts { get; set; }
        public DbSet<BlueprintComponent> BlueprintResources { get; set; }
        public DbSet<BountyReward> BountyRewards { get; set; }
        public DbSet<Collectible> Collectibles { get; set; }
        public DbSet<DailyTributeMilestoneReward> DailyTributeMilestoneRewards { get; set; }
        public DbSet<DefectionMissionReward> DefectionMissionRewards { get; set; }
        public DbSet<DefenseMissionReward> DefenseMissionRewards { get; set; }
        public DbSet<DerelictCacheDrop> DerelictCacheDrops { get; set; }
        public DbSet<DisruptionMissionReward> DisruptionMissionRewards { get; set; }
        public DbSet<EnemyItemDrop> EnemyItemDrops { get; set; }
        public DbSet<EnemyMission> EnemyMissions { get; set; }
        public DbSet<EnemyTileset> EnemyTilesets { get; set; }
        public DbSet<ExterminateMissionReward> ExterminateMissionRewards { get; set; }
        public DbSet<ExterminateResourceCacheReward> ExterminateResourceCacheRewards { get; set; }
        public DbSet<Fish> Fish { get; set; }
        public DbSet<GranumVoidReward> GranumVoidRewards { get; set; }
        public DbSet<InfestedSalvageMissionReward> InfestedSalvageRewards { get; set; }
        public DbSet<InvasionReward> InvasionRewards { get; set; }
        public DbSet<KuvaItem> KuvaItems { get; set; }
        public DbSet<MarketItem> MarketItems { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<NorasChoiceNightwaveOffering> NorasChoiceNightwaveOfferings { get; set; }
        public DbSet<QuestReward> QuestRewards { get; set; }
        public DbSet<SabotageMissionReward> SabotageMissionRewards { get; set; }
        public DbSet<SanctuaryOnslaughtEliteReward> SanctuaryOnslaughtEliteRewards { get; set; }
        public DbSet<SanctuaryOnslaughtReward> SanctuaryOnslaughtRewards { get; set; }
        public DbSet<SpyMissionReward> SpyMissionRewards { get; set; }
        public DbSet<SurvivalMissionReward> SurvivalMissionRewards { get; set; }
        public DbSet<SyndicateOffering> SyndicateOfferings { get; set; }
        public DbSet<VoidFissureMissionReward> VoidFissureMissionRewards { get; set; }
        public DbSet<VoidRelicDrop> VoidRelicDrops { get; set; }
        public DbSet<UserCollectible> UserCollectibles { get; set; }

        public void CreateUserData(string userId) {
            var userCollectibles = from collectible in Collectibles
                                   select new UserCollectible() {
                                       ItemName = collectible.ItemName,
                                       UserId = userId
                                   };
            UserCollectibles.AddRange(userCollectibles);
            SaveChanges();
        }

        public void CreateCollectibleData(Collectible newCollectible) {
            Collectibles.Add(newCollectible);
            var newUserCollectibles = from user in Users
                                      select new UserCollectible() {
                                          ItemName = newCollectible.ItemName,
                                          UserId = user.Id
                                      };
            UserCollectibles.AddRange(newUserCollectibles);
            SaveChanges();
        }

        public void UpdateCollectibleData(string name, Collectible newCollectible) {
            var userCollectibles = from userCollectible in UserCollectibles
                                   where userCollectible.ItemName == name
                                   select new UserCollectible() {
                                       UserId = userCollectible.UserId,
                                       ItemName = newCollectible.ItemName,
                                       Mastered = userCollectible.Mastered,
                                       Obtained = userCollectible.Obtained,
                                       OnWishlist = userCollectible.OnWishlist
                                   };
            RemoveCollectibleData(name);
            Collectibles.Add(newCollectible);
            UserCollectibles.AddRange(userCollectibles);
            SaveChanges();
        }

        public void RemoveCollectibleData(string name) {
            var collectible = (from col in Collectibles
                               where col.ItemName == name
                               select col).FirstOrDefault();
            Collectibles.Remove(collectible);
            var userCollectibles = from userCollectible in UserCollectibles
                                   where userCollectible.ItemName == name
                                   select userCollectible;
            UserCollectibles.RemoveRange(userCollectibles);
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            SetupKeys(modelBuilder);
            SeedData(modelBuilder);
            SeedRoles(modelBuilder);
        }

        private void SetupKeys(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AssassinationMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName });
            modelBuilder.Entity<BaroKiteerProduct>()
                .HasKey(entry => new { entry.ItemName, entry.SaleDate });
            modelBuilder.Entity<BlueprintComponent>()
                .HasKey(entry => new { entry.ItemName, entry.ComponentName});
            modelBuilder.Entity<BountyReward>()
                .HasKey(entry => new { entry.ItemName, entry.Location, entry.Rotation, entry.BountyTier, entry.BountyStage });
            modelBuilder.Entity<Collectible>()
                .HasKey(entry => entry.ItemName );
            modelBuilder.Entity<DailyTributeMilestoneReward>()
                .HasKey(entry => entry.ItemName);
            modelBuilder.Entity<DefectionMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName, entry.Rotation });
            modelBuilder.Entity<DefenseMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.Rotation, entry.MissionName });
            modelBuilder.Entity<DerelictCacheDrop>()
                .HasKey(entry => new { entry.ItemName, entry.System, entry.Rotation, entry.Faction });
            modelBuilder.Entity<DisruptionMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName, entry.Rotation});
            modelBuilder.Entity<EnemyItemDrop>()
                .HasKey(entry => new { entry.ItemName, entry.EnemyName });
            modelBuilder.Entity<EnemyMission>()
                .HasKey(entry => new { entry.EnemyName, entry.MissionName });
            modelBuilder.Entity<EnemyTileset>()
                .HasKey(entry => new { entry.EnemyName, entry.TilesetName });
            modelBuilder.Entity<ExterminateMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName });
            modelBuilder.Entity<ExterminateResourceCacheReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName, entry.CacheNumber });
            modelBuilder.Entity<Fish>()
                .HasKey(entry => new { entry.FishName, entry.Biome });
            modelBuilder.Entity<GranumVoidReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionType, entry.Rotation });
            modelBuilder.Entity<InfestedSalvageMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.Rotation });
            modelBuilder.Entity<InvasionReward>()
                .HasKey(entry => new { entry.ItemName });
            modelBuilder.Entity<KuvaItem>()
                .HasKey(entry => new { entry.ItemName });
            modelBuilder.Entity<MarketItem>()
                .HasKey(entry => new { entry.ItemName });
            modelBuilder.Entity<Mission>()
                .HasKey(entry => new { entry.MissionName });
            modelBuilder.Entity<NorasChoiceNightwaveOffering>()
                .HasKey(entry => new { entry.ItemName });
            modelBuilder.Entity<QuestReward>()
                .HasKey(entry => new { entry.ItemName });
            modelBuilder.Entity<SabotageMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName, entry.Rotation });
            modelBuilder.Entity<SanctuaryOnslaughtEliteReward>()
                .HasKey(entry => new { entry.ItemName, entry.Rotation });
            modelBuilder.Entity<SanctuaryOnslaughtReward>()
                .HasKey(entry => new { entry.ItemName, entry.Rotation });
            modelBuilder.Entity<SpyMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName, entry.UnlockedVaultNumber });
            modelBuilder.Entity<SurvivalMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.MissionName, entry.Rotation });
            modelBuilder.Entity<SyndicateOffering>()
                .HasKey(entry => new { entry.ItemName });
            modelBuilder.Entity<UserCollectible>()
                .HasKey(entry => new { entry.ItemName, entry.UserId });
                
            modelBuilder.Entity<VoidFissureMissionReward>()
                .HasKey(entry => new { entry.ItemName, entry.SystemName });
            modelBuilder.Entity<VoidRelicDrop>()
                .HasKey(entry => new { entry.ItemName, entry.RelicName });


        }

        private void SeedData(ModelBuilder modelBuilder) {
            SeedDataFromCsv<AssassinationMissionReward>(modelBuilder, "AssassinationRewards");
            SeedDataFromCsv<BaroKiteerProduct>(modelBuilder, "BaroKiteerTradeHistory");
            SeedDataFromCsv<BlueprintComponent>(modelBuilder, "BlueprintsComponents");
            SeedDataFromCsv<BountyReward>(modelBuilder, "BountyRewards");
            SeedDataFromCsv<Collectible>(modelBuilder, "Collectibles");
            SeedDataFromCsv<DailyTributeMilestoneReward>(modelBuilder, "DailyTributeMilestoneRewards");
            SeedDataFromCsv<DefectionMissionReward>(modelBuilder, "DefectionMissionRewards");
            SeedDataFromCsv<DefenseMissionReward>(modelBuilder, "DefenseMissionRewards");
            SeedDataFromCsv<DerelictCacheDrop>(modelBuilder, "DerelictCacheDrops");
            SeedDataFromCsv<DisruptionMissionReward>(modelBuilder, "DisruptionMissionRewards");
            SeedDataFromCsv<EnemyItemDrop>(modelBuilder, "EnemyItemDrops");
            SeedDataFromCsv<EnemyMission>(modelBuilder, "EnemyMissions");
            SeedDataFromCsv<EnemyTileset>(modelBuilder, "EnemyTilesets");
            SeedDataFromCsv<ExterminateMissionReward>(modelBuilder, "ExterminateMissionRewards");
            SeedDataFromCsv<ExterminateResourceCacheReward>(modelBuilder, "ExterminateResourceCacheRewards");
            SeedDataFromCsv<Fish>(modelBuilder, "Fish");
            SeedDataFromCsv<GranumVoidReward>(modelBuilder, "GranumVoidRewards");
            SeedDataFromCsv<InfestedSalvageMissionReward>(modelBuilder, "InfestedSalvageMissionRewards");
            SeedDataFromCsv<InvasionReward>(modelBuilder, "InvasionRewards");
            SeedDataFromCsv<KuvaItem>(modelBuilder, "KuvaItems");
            SeedDataFromCsv<MarketItem>(modelBuilder, "MarketItems");
            SeedDataFromCsv<Mission>(modelBuilder, "Missions");
            SeedDataFromCsv<NorasChoiceNightwaveOffering>(modelBuilder, "NightwaveOfferings_NorasChoice");
            SeedDataFromCsv<QuestReward>(modelBuilder, "QuestRewards");
            SeedDataFromCsv<SabotageMissionReward>(modelBuilder, "SabotageMissionRewards");
            SeedDataFromCsv<SanctuaryOnslaughtEliteReward>(modelBuilder, "SanctuaryOnslaughtEliteRewards");
            SeedDataFromCsv<SanctuaryOnslaughtReward>(modelBuilder, "SanctuaryOnslaughtRewards");
            SeedDataFromCsv<SpyMissionReward>(modelBuilder, "SpyMissionRewards");
            SeedDataFromCsv<SurvivalMissionReward>(modelBuilder, "SurvivalMissionRewards");
            SeedDataFromCsv<SyndicateOffering>(modelBuilder, "SyndicateOfferings");
            SeedDataFromCsv<VoidFissureMissionReward>(modelBuilder, "VoidFissureMissionRewards");
            SeedDataFromCsv<VoidRelicDrop>(modelBuilder, "VoidRelicDrops");
        }

        private void SeedRoles(ModelBuilder modelBuilder) {
            var adminRole = new IdentityRole("Administrator");
            var userRole = new IdentityRole("User");
            modelBuilder.Entity<IdentityRole>().HasData(adminRole);
            modelBuilder.Entity<IdentityRole>().HasData(userRole);
        }

        private void SeedDataFromCsv<T>(ModelBuilder builder, string seedFileName) where T : class {
            // Debugger.Launch();
            var seedData = CsvSeedHelper.GetDataFromSeed<T>(seedFileName);
            foreach (var item in seedData) {
                builder.Entity<T>().HasData(item);
            }
        }
    }
}