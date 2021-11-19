using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    // [Route("[controller]/[action]/")]
    [ApiController]
    public class ItemSourceController : ControllerBase {
        #region Endpoints
        [Route("[controller]/{itemName}")]
        [HttpGet]
        public ItemSources Get(string itemName) {
            var result = new ItemSources();
            result.ItemName = itemName;
            PopulateSources(result);
            return result;
        }
        #endregion

        #region Body

        private WarframeProgressTrackerContext _context;
        public ItemSourceController(WarframeProgressTrackerContext context) {
            _context = context;
        }

        private void PopulateSources(ItemSources sources) {
            var itemName = sources.ItemName;
            if (string.IsNullOrEmpty(itemName)) return;
            sources.AssassinationMissionSources = GetAssassinationSources(itemName);
            sources.BaroKiteerSources = GetBaroKiteerSources(itemName);
            sources.BountySources = GetBountySources(itemName);
            sources.DailyTributeMilestoneSources = GetDailyTributeRewardSources(itemName);
            sources.DefectionMissionSources = GetDefectionMissionSources(itemName);
            sources.DefenseMissionSources = GetDefenseMissionSources(itemName);
            sources.DerelictCacheSources = GetDerelictCacheSources(itemName);
            sources.DisruptionMissionSources = GetDisruptionMissionSources(itemName);
            sources.EnemyItemDropSources = GetEnemyItemDropSources(itemName);
            sources.ExterminateMissionSources = GetExterminateMissionSources(itemName);
            sources.ExterminateResourceCacheSources = GetExterminateResourceCacheSources(itemName);
            sources.GranumVoidSources = GetGranumVoidSources(itemName);
            sources.InfestedSalvageMissionSources = GetInfestedSalvageMissionSources(itemName);
            sources.InvasionSources = GetInvasionSources(itemName);
            sources.KuvaSources = GetKuvaSources(itemName);
            sources.MarketSources = GetMarketSources(itemName);
            sources.NightWingSources = GetNightWingSources(itemName);
            sources.QuestSources = GetQuestSources(itemName);
            sources.SabotageMissionSources = GetSabotageMissionSources(itemName);
            sources.SanctuaryOnslaughtEliteSources = GetSanctuaryOnslaughtEliteSources(itemName);
            sources.SanctuaryOnslaughtSources = GetSanctuaryOnslaughtSources(itemName);
            sources.SpyMissionSources = GetSpyMissionSources(itemName);
            sources.SurvivalMissionSources = GetSurvivalMissionSources(itemName);
            sources.SyndicateSources = GetSyndicateSources(itemName);
            sources.VoidFissureMissionSources = GetVoidFissureMissionSources(itemName);
            sources.VoidRelicSources = GetVoidRelicSources(itemName);
        }

        private IEnumerable<AssassinationMissionSource> GetAssassinationSources(string itemName) {
            return from data in _context.AssassinationMissionRewards
                   where data.ItemName == itemName
                   select new AssassinationMissionSource() {
                       Mission = data.Mission,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<BaroKiteerSource> GetBaroKiteerSources(string itemName) {
            return from data in _context.BaroKiteerProducts
                   where data.ItemName == itemName
                   select new BaroKiteerSource() {
                       SaleDate = data.SaleDate,
                       CreditsCost = data.CreditsCost,
                       DucatsCost = data.DucatsCost
                   };
        }

        private IEnumerable<BountySource> GetBountySources(string itemName) {
            return from data in _context.BountyRewards
                   where data.ItemName == itemName
                   select new BountySource() {
                       Location = data.Location,
                       Rotation = data.Rotation,
                       BountyTier = data.BountyTier,
                       BountyStage = data.BountyStage,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<DailyTributeMilestoneSource> GetDailyTributeRewardSources(string itemName) {
            return from data in _context.DailyTributeMilestoneRewards
                   where data.ItemName == itemName
                   select new DailyTributeMilestoneSource() { };
        }

        private IEnumerable<DefectionMissionSource> GetDefectionMissionSources(string itemName) {
            return from data in _context.DefenseMissionRewards
                   where data.ItemName == itemName
                   select new DefectionMissionSource() {
                       Rotation = data.Rotation,
                       MissionName = data.MissionName,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<DefenseMissionSource> GetDefenseMissionSources(string itemName) {
            return from data in _context.DefenseMissionRewards
                   where data.ItemName == itemName
                   select new DefenseMissionSource() {
                       Rotation = data.Rotation,
                       MissionName = data.MissionName,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<DerelictCacheSource> GetDerelictCacheSources(string itemName) {
            return from data in _context.DerelictCacheDrops
                   where data.ItemName == itemName
                   select new DerelictCacheSource() {
                       System = data.System,
                       Rotation = data.Rotation,
                       Faction = data.Faction,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<DisruptionMissionSource> GetDisruptionMissionSources(string itemName) {
            return from data in _context.DisruptionMissionRewards
                   where data.ItemName == itemName
                   select new DisruptionMissionSource() {
                       MissionName = data.MissionName,
                       Rotation = data.Rotation,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<EnemyItemDropSource> GetEnemyItemDropSources(string itemName) {
            return from data in _context.EnemyItemDrops
                   where data.ItemName == itemName
                   select new EnemyItemDropSource() {
                       EnemyName = data.EnemyName,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<ExterminateMissionSource> GetExterminateMissionSources(string itemName) {
            return from data in _context.ExterminateMissionRewards
                   where data.ItemName == itemName
                   select new ExterminateMissionSource() {
                       MissionName = data.MissionName,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<ExterminateResourceCacheSource> GetExterminateResourceCacheSources(string itemName) {
            return from data in _context.ExterminateResourceCacheRewards
                   where data.ItemName == itemName
                   select new ExterminateResourceCacheSource() {
                       MissionName = data.MissionName,
                       CacheNumber = data.CacheNumber,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<GranumVoidSource> GetGranumVoidSources(string itemName) {
            return from data in _context.GranumVoidRewards
                   where data.ItemName == itemName
                   select new GranumVoidSource() {
                       MissionType = data.MissionType,
                       Rotation = data.Rotation,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<InfestedSalvageMissionSource> GetInfestedSalvageMissionSources(string itemName) {
            return from data in _context.InfestedSalvageRewards
                   where data.ItemName == itemName
                   select new InfestedSalvageMissionSource() {
                       MissionName = data.MissionName,
                       Rotation = data.Rotation,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<InvasionSource> GetInvasionSources(string itemName) {
            return from data in _context.InvasionRewards
                   where data.ItemName == itemName
                   select new InvasionSource() { };
        }

        private IEnumerable<KuvaSource> GetKuvaSources(string itemName) {
            return from data in _context.KuvaItems
                   where data.ItemName == itemName
                   select new KuvaSource() { };
        }

        private IEnumerable<MarketSource> GetMarketSources(string itemName) {
            return from data in _context.MarketItems
                   where data.ItemName == itemName
                   select new MarketSource() {
                       CreditsCost = data.CreditsCost
                   };
        }

        private IEnumerable<NightWingSource> GetNightWingSources(string itemName) {
            return from data in _context.NorasChoiceNightwaveOfferings
                   where data.ItemName == itemName
                   select new NightWingSource() {
                       Season = "Nora's Choice",
                       CredsCost = data.CredsCost
                   };
        }

        private IEnumerable<QuestSource> GetQuestSources(string itemName) {
            return from data in _context.QuestRewards
                   where data.ItemName == itemName
                   select new QuestSource() {
                       QuestName = data.QuestName
                   };
        }

        private IEnumerable<SabotageMissionSource> GetSabotageMissionSources(string itemName) {
            return from data in _context.SabotageMissionRewards
                   where data.ItemName == itemName
                   select new SabotageMissionSource() {
                       MissionName = data.MissionName,
                       Rotation = data.Rotation,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<SanctuaryOnslaughtEliteSource> GetSanctuaryOnslaughtEliteSources(string itemName) {
            return from data in _context.SanctuaryOnslaughtEliteRewards
                   where data.ItemName == itemName
                   select new SanctuaryOnslaughtEliteSource() {
                       Rotation = data.Rotation,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<SanctuaryOnslaughtSource> GetSanctuaryOnslaughtSources(string itemName) {
            return from data in _context.SanctuaryOnslaughtRewards
                   where data.ItemName == itemName
                   select new SanctuaryOnslaughtSource() {
                       Rotation = data.Rotation,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<SpyMissionSource> GetSpyMissionSources(string itemName) {
            return from data in _context.SpyMissionRewards
                   where data.ItemName == itemName
                   select new SpyMissionSource() {
                       MissionName = data.MissionName,
                       UnlockedVaultNumber = data.UnlockedVaultNumber,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<SurvivalMissionSource> GetSurvivalMissionSources(string itemName) {
            return from data in _context.SurvivalMissionRewards
                   where data.ItemName == itemName
                   select new SurvivalMissionSource() {
                       MissionName = data.MissionName,
                       Rotation = data.Rotation,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<SyndicateSource> GetSyndicateSources(string itemName) {
            return from data in _context.SyndicateOfferings
                   where data.ItemName == itemName
                   select new SyndicateSource() {
                       SyndicateName = data.SyndicateName,
                       SyndicateRankRequired = data.SyndicateRankRequired,
                       StandingCost = data.StandingCost
                   };
        }

        private IEnumerable<VoidFissureMissionSource> GetVoidFissureMissionSources(string itemName) {
            return from data in _context.VoidFissureMissionRewards
                   where data.ItemName == itemName
                   select new VoidFissureMissionSource() {
                       SystemName = data.SystemName,
                       DropChance = data.DropChance
                   };
        }

        private IEnumerable<VoidRelicSource> GetVoidRelicSources(string itemName) {
            return from data in _context.VoidRelicDrops
                   where data.ItemName == itemName
                   select new VoidRelicSource() {
                       RelicName = data.RelicName,
                       Rarity = data.Rarity
                   };
        }

        #endregion
    }
}
