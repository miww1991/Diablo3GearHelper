using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public enum AffixQuality
    {
        Primary,
        Secondary
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AffixType
    {
        // Primary Stats
        [EnumMember(Value = "Intelligence_Item")]
        Intelligence,
        [EnumMember(Value = "Dexterity_Item")]
        Dexterity,
        [EnumMember(Value = "Strength_Item")]
        Strength,
        [EnumMember(Value = "Vitality_Item")]
        Vitality,

        // Offensive Stats
        AverageDamage,
        //[EnumMember(Value = "")]
        PercentDamage,
        [EnumMember(Value = "Crit_Percent_Bonus_Capped")]
        CriticalHitChance,
        [EnumMember(Value = "Crit_Damage_Percent")]
        CriticalHitDamage,
        //[EnumMember(Value = "")]
        PercentDamageAgainstElites,
        [EnumMember(Value = "Attacks_Per_Second_Percent")]
        AttackSpeed,
        //[EnumMember(Value = "")]
        AreaDamage,

        // Defensive Stats
        //[EnumMember(Value = "")]
        PercentLife,
        [EnumMember(Value = "Armor_Bonus_Item")]
        BonusArmor,
        [EnumMember(Value = "Thorns_Fixed#Physical")]
        Thorns,
        [EnumMember(Value = "Resistance_All")]
        AllResistances,
        [EnumMember(Value = "Resistance#Fire")]
        FireResistance,
        [EnumMember(Value = "Resistance#Cold")]
        ColdResistance,
        [EnumMember(Value = "Resistance#Lightning")]
        LightningResistance,
        [EnumMember(Value = "Resistance#Arcane")]
        ArcaneResistance,
        [EnumMember(Value = "Resistance#Poison")]
        PoisonResistance,
        [EnumMember(Value = "Damage_Percent_Reduction_From_Ranged")]
        ReducedDamageFromRangedAttacks,

        // Elemental Damage
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Arcane")]
        ArcaneDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Fire")]
        FireDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Cold")]
        ColdDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Lightning")]
        LightningDamage,

        // Healing
        //[EnumMember(Value = "")]
        LifeOnHit,
        //[EnumMember(Value = "")]
        LifePerKill,
        //[EnumMember(Value = "")]
        LifePerSecond,
        [EnumMember(Value = "Health_Globe_Bonus_Health")]
        HealthGloveAndPotionExtraLife,

        // Utility
        //[EnumMember(Value = "")]
        ResourceCostReduction,
        //[EnumMember(Value = "")]
        CooldownReduction,
        [EnumMember(Value = "Gold_PickUp_Radius")]
        GoldPickupRadius,
        //[EnumMember(Value = "")]
        BonusExperienceOnKill,
        [EnumMember(Value = "Experience_Bonus_Percent")]
        BonusExperiencePercent,
        [EnumMember(Value = "Movement_Scalar")]
        MovementSpeed,
        [EnumMember(Value = "Gold_Find")]
        ExtraGoldFromMonsters,

        // Sockets
        [EnumMember(Value = "Sockets")]
        Sockets,

        // Wizard Skills
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_ArcaneTorrent")]
        ArcaneTorrentDamage,
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_ArcaneOrb")]
        ArcaneOrbDamage,
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_Disintegrate")]
        DistintegrateDamage,
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_BlackHole")]
        BlackHoleDamage,

        // Wizard Utilities
        [EnumMember(Value = "Resource_On_Crit#Arcanum")]
        ArcanePowerOnCrit,
        [EnumMember(Value = "Resource_Max_Bonus#Arcanum")]
        MaximumArcanePower,

        // Miscellaneous
        [EnumMember(Value = "Item_Level_Requirement_Reduction")]
        ReducedLevelRequirement,
        [EnumMember(Value = "On_Hit_Immobilize_Proc_Chance")]
        ChanceToImmobilizeOnHit
    }

    public class Affix
    {
        public bool Enchanted { get; set; }

        public float Value { get; set; }

        public AffixType AffixType { get; set; }

        public AffixQuality AffixQuality { get; set; }

        public Affix()
        {

        }
    }
}
