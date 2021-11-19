using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WarframeProgressTrackerApi.Models;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            SeedDataFromCsv<AssassinationMissionReward>(modelBuilder, "AssassinationRewards");
            SeedDataFromCsv<BaroKiteerProduct>(modelBuilder, "BaroKiteerTradeHistory");
            SeedDataFromCsv<BlueprintComponent>(modelBuilder, "BlueprintComponents");
            SeedDataFromCsv<BountyReward>(modelBuilder, "BountyRewards");
            SeedDataFromCsv<Collectible>(modelBuilder, "Collectibles");
            SeedDataFromCsv<DailyTributeMilestoneReward>(modelBuilder, "DailyTributeMilestoneRewards");
            SeedDataFromCsv<DefectionMissionReward>(modelBuilder, "DefectionMissionRewards");
            SeedDataFromCsv<DefenseMissionReward>(modelBuilder, "DefenseMissionRewards");
            SeedDataFromCsv<DerelictCacheDrop>(modelBuilder, "DerelictCacheDrops");
            SeedDataFromCsv<DisruptionMissionReward>(modelBuilder, "DisruptionMissionRewards");
            SeedDataFromCsv<EnemyItemDrop>(modelBuilder, "EnemyItemDrops");
            SeedDataFromCsv<EnemyMission>(modelBuilder, "EnemyMissions");
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

        private void SeedDataFromCsv<T>(ModelBuilder builder, string seedFileName) where T : class {
            var seedData = CsvSeedHelper.GetDataFromSeed<T>(seedFileName);
            foreach (var item in seedData) {
                builder.Entity<T>().HasData(item);
            }
        }
    }
}