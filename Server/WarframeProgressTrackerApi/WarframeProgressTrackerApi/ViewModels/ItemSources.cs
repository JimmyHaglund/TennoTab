using System;
using System.Collections.Generic;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.ViewModels {
    public class ItemSources {
        public string ItemName { get; set; }
        public IEnumerable<AssassinationMissionSource> AssassinationMissionSources { get; set; }
        public IEnumerable<BaroKiteerSource> BaroKiteerSources { get; set; }
        public IEnumerable<BountySource> BountySources { get; set; }
        public IEnumerable<DailyTributeMilestoneSource> DailyTributeMilestoneSources { get; set; }
        public IEnumerable<DefectionMissionSource> DefectionMissionSources { get; set; }
        public IEnumerable<DefenseMissionSource> DefenseMissionSources { get; set; }
        public IEnumerable<DerelictCacheSource> DerelictCacheSources { get; set; }
        public IEnumerable<DisruptionMissionSource> DisruptionMissionSources { get; set; }
        public IEnumerable<EnemyItemDropSource> EnemyItemDropSources { get; set; }
        public IEnumerable<ExterminateMissionSource> ExterminateMissionSources { get; set; }
        public IEnumerable<ExterminateResourceCacheSource> ExterminateResourceCacheSources { get; set; }
        public IEnumerable<GranumVoidSource> GranumVoidSources { get; set; }
        public IEnumerable<InfestedSalvageMissionSource> InfestedSalvageMissionSources { get; set; }
        public IEnumerable<InvasionSource> InvasionSources { get; set; }
        public IEnumerable<KuvaSource> KuvaSources { get; set; }
        public IEnumerable<MarketSource> MarketSources { get; set; }
        public IEnumerable<NightWingSource> NightWingSources { get; set; }
        public IEnumerable<QuestSource> QuestSources { get; set; }
        public IEnumerable<SabotageMissionSource> SabotageMissionSources { get; set; }
        public IEnumerable<SanctuaryOnslaughtEliteSource> SanctuaryOnslaughtEliteSources { get; set; }
        public IEnumerable<SanctuaryOnslaughtSource> SanctuaryOnslaughtSources { get; set; }
        public IEnumerable<SpyMissionSource> SpyMissionSources { get; set; }
        public IEnumerable<SurvivalMissionSource> SurvivalMissionSources { get; set; }
        public IEnumerable<SyndicateSource> SyndicateSources { get; set; }
        public IEnumerable<VoidFissureMissionSource> VoidFissureMissionSources { get; set; }
        public IEnumerable<VoidRelicSource> VoidRelicSources { get; set; }
    }
    #region Source Classes
    public class AssassinationMissionSource {
        public string Mission { get; set; }
        public float DropChance { get; set; }
    }

    public class BaroKiteerSource {
        public DateTime SaleDate { get; set; }
        public int CreditsCost { get; set; }
        public int DucatsCost { get; set; }
    }

    public class BountySource {
        public string Location { get; set; }
        public char Rotation { get; set; }
        public byte BountyTier { get; set; }
        public byte BountyStage { get; set; }
        public float DropChance { get; set; }
    }

    public class DailyTributeMilestoneSource { }

    public class DefectionMissionSource {
        public char Rotation { get; set; }
        public string MissionName { get; set; }
        public float DropChance { get; set; }
    }

    public class DefenseMissionSource {
        public char Rotation { get; set; }
        public string MissionName { get; set; }
        public float DropChance { get; set; }
    }

    public class DerelictCacheSource {
        public string System { get; set; }
        public char Rotation { get; set; }
        public string Faction { get; set; }
        public float DropChance { get; set; }
    }

    public class DisruptionMissionSource {
        public string MissionName { get; set; }
        public char Rotation { get; set; }
        public float DropChance { get; set; }
    }

    public class EnemyItemDropSource {
        public string EnemyName { get; set; }
        public float DropChance { get; set; }
    }

    public class ExterminateMissionSource {
        public string MissionName { get; set; }
        public float DropChance { get; set; }
    }

    public class ExterminateResourceCacheSource {
        public string MissionName { get; set; }
        public byte CacheNumber { get; set; }
        public float DropChance { get; set; }
    }

    public class GranumVoidSource {
        public string MissionType { get; set; }
        public char Rotation { get; set; }
        public float DropChance { get; set; }
    }

    public class InfestedSalvageMissionSource {
        public char Rotation { get; set; }
        public string MissionName { get; set; }
        public float DropChance { get; set; }
    }

    public class InvasionSource { }

    public class KuvaSource { }

    public class MarketSource {
        public int CreditsCost { get; set; }
    }

    public class NightWingSource {
        public string Season { get; set; }
        public string CredsCost { get; set; }
    }

    public class QuestSource {
        public string QuestName { get; set; }
    }

    public class SabotageMissionSource {
        public string MissionName { get; set; }
        public char Rotation { get; set; }
        public float DropChance { get; set; }
    }

    public class SanctuaryOnslaughtEliteSource {
        public char Rotation { get; set; }
        public float DropChance { get; set; }
    }

    public class SanctuaryOnslaughtSource {
        public char Rotation { get; set; }
        public float DropChance { get; set; }
    }

    public class SpyMissionSource {
        public string MissionName { get; set; }
        public byte UnlockedVaultNumber { get; set; }
        public float DropChance { get; set; }
    }

    public class SurvivalMissionSource {
        public string MissionName { get; set; }
        public char Rotation { get; set; }
        public float DropChance { get; set; }
    }

    public class SyndicateSource {
        public string SyndicateName { get; set; }
        public byte SyndicateRankRequired { get; set; }
        public uint StandingCost { get; set; }
    }

    public class VoidFissureMissionSource {
        public string SystemName { get; set; }
        public float DropChance { get; set; }
    }

    public class VoidRelicSource {
        public string RelicName { get; set; }
        public float Rarity { get; set; }
    }
    #endregion
}
