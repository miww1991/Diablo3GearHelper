using System;
using System.Collections.Generic;
using System.Linq;
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
        Intelligence,
        Dexterity,
        Strength,
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
        BonusArmor,
        Thorns,
        AllResistances,
        FireResistance,
        ColdResistance,

        // Elemental Damage
        ArcaneDamage,
        FireDamage,
        ColdDamage,
        LightningDamage,

        // Healing
        LifeOnHit,
        LifePerKill,
        LifePerSecond,

        // Utility
        ResourceCostReduction,
        CooldownReduction,
        GoldPickupRadius,

        // Sockets
        Sockets1,
        Sockets2,
        Sockets3,

        // Skills Damage

        // Miscellaneous
        ReducedLevelRequirement,
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
