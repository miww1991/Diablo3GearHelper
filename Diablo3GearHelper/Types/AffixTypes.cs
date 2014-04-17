using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Diablo3GearHelper.Types
{
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

        // Defensive Stats
        [EnumMember(Value = "Hitpoints_Max_Percent_Bonus_Item")]
        PercentLife,
        [EnumMember(Value = "Armor_Bonus_Item")]
        BonusArmor,
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
        [EnumMember(Value = "Resistance#Holy")]
        HolyResistance,
        [EnumMember(Value = "Resistance#Physical")]
        PhysicalResistance,
        [EnumMember(Value = "ignoreMe2")]
        Armor, // General Armor

        // Elemental Damage
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Arcane")]
        ArcaneDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Fire")]
        FireDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Cold")]
        ColdDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Lightning")]
        LightningDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Holy")]
        HolyDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Poison")]
        PoisonDamage,
        [EnumMember(Value = "Damage_Dealt_Percent_Bonus#Physical")]
        PhysicalDamage,

        // Sockets
        [EnumMember(Value = "Sockets")]
        Sockets,

        // Wizard Skills
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_ArcaneTorrent")]
        ArcaneTorrentDamage,
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_ArcaneOrb")]
        ArcaneOrbDamage,
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_Disintegrate")]
        DisintegrateDamage,
        [EnumMember(Value = "Power_Damage_Percent_Bonus#Wizard_Meteor")]
        MeteorDamage,

        InvalidAffix
    }
}
