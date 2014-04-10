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
        PercentDamage,
        CriticalHitChance,
        CriticalHitDamage,
        PercentDamageAgainstElites,
        AttackSpeed,
        AreaDamage,

        // Defensive Stats
        PercentLife,
        [EnumMember(Value = "Armor_Bonus_Item")]
        BonusArmor,
        Thorns,
        AllResistances,
        FireResistance,
        ColdResistance,
        [EnumMember(Value = "")]
        LightningResistance,
        [EnumMember(Value = "")]
        ArcaneResistance,
        [EnumMember(Value = "")]
        ReducedDamageFromRangedAttacks,

        // Elemental Damage
        [EnumMember(Value = "")]
        ArcaneDamage,
        [EnumMember(Value = "")]
        FireDamage,
        [EnumMember(Value = "")]
        ColdDamage,
        [EnumMember(Value = "")]
        LightningDamage,

        // Healing
        [EnumMember(Value = "")]
        LifeOnHit,
        [EnumMember(Value = "")]
        LifePerKill,
        [EnumMember(Value = "")]
        LifePerSecond,
        [EnumMember(Value = "")]
        HealthGloveAndPotionExtraLife,

        // Utility
        [EnumMember(Value = "")]
        ResourceCostReduction,
        [EnumMember(Value = "")]
        CooldownReduction,
        [EnumMember(Value = "")]
        GoldPickupRadius,
        [EnumMember(Value = "")]
        BonusExperienceOnKill,
        [EnumMember(Value = "")]
        BonusExperiencePercent,
        [EnumMember(Value = "")]
        MovementSpeed,
        [EnumMember(Value = "")]
        ExtraGoldFromMonsters,

        // Sockets
        [EnumMember(Value = "Sockets")]
        Sockets,

        // Wizard Skills
        [EnumMember(Value = "")]
        ArcaneTorrentDamage,
        [EnumMember(Value = "")]
        ArcaneOrbDamage,
        [EnumMember(Value = "")]
        DistintegrateDamage,
        [EnumMember(Value = "")]
        BlackHoleDamage,

        // Wizard Utilities
        [EnumMember(Value = "")]
        ArcanePowerOnCrit,
        [EnumMember(Value = "")]
        MaximumArcanePower,

        // Miscellaneous
        [EnumMember(Value = "")]
        ReducedLevelRequirement,
        [EnumMember(Value = "")]
        ChanceToImmobilizeOnHit,
    }

    public class Affix
    {
        public bool Enchanted { get; set; }

        public int Value { get; set; }

        public Affix()
        {

        }
    }
}
