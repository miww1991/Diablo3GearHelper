using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class MaxStatLookupTable
    {
        private static MaxStatLookupTable instance;

        public static MaxStatLookupTable Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MaxStatLookupTable();
                }
                return instance;
            }
        }

        public readonly MaxStatTableEntry[] Table =
        {
            /*-----------------------------------------------------------------------------------------------------
                                                            HELMS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Intelligence,         ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Dexterity,            ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Strength,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Vitality,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.CriticalHitChance,    ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.BonusArmor,           ItemQuality.Rare,       545.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Sockets,              ItemQuality.Rare,       1.0f    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ArcaneTorrentDamage,  ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ArcaneOrbDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.DisintegrateDamage,   ItemQuality.Rare,       15.0f   ),

            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Intelligence,         ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Dexterity,            ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Strength,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Vitality,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.06f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.AttackSpeed,          ItemQuality.Legendary,  0.06f,  new string[] { "Andariel's Visage", "Broken Crown", "Mempo of Twilight" }   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PercentLife,          ItemQuality.Legendary,  0.15f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.BonusArmor,           ItemQuality.Legendary,  595.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PoisonResistance,     ItemQuality.Legendary,  200.0f, new string[] { "Andariel's Visage" }    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ArcaneDamage,         ItemQuality.Legendary,  20.0f,  new string[] { "Andariel's Visage" }    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.FireDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Andariel's Visage" }    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ColdDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Andariel's Visage" }    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.LightningDamage,      ItemQuality.Legendary,  20.0f,  new string[] { "Andariel's Visage", "Storm Crow" }  ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.HolyDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Andariel's Visage" }    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PhysicalDamage,       ItemQuality.Legendary,  20.0f,  new string[] { "Andariel's Visage" }    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.PoisonDamage,         ItemQuality.Legendary,  20.0f,  new string[] { "Andariel's Visage" }    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.Sockets,              ItemQuality.Legendary,  1.0f    ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ArcaneTorrentDamage,  ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.ArcaneOrbDamage,      ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.Helm,        AffixType.DisintegrateDamage,   ItemQuality.Legendary,  15.0f   ),

            /*-----------------------------------------------------------------------------------------------------
                                                            AMULETS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Intelligence,         ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Dexterity,            ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Strength,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Vitality,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.CriticalHitChance,    ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.CriticalHitDamage,    ItemQuality.Rare,       0.50f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.AttackSpeed,          ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PercentLife,          ItemQuality.Rare,       0.15f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ArcaneDamage,         ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.FireDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ColdDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.LightningDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.HolyDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PhysicalDamage,       ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PoisonDamage,         ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Sockets,              ItemQuality.Rare,       1.0f    ),

            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Intelligence,         ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Dexterity,            ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Strength,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Vitality,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.10f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.CriticalHitDamage,    ItemQuality.Legendary,  1.0f    ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.AttackSpeed,          ItemQuality.Legendary,  0.07f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PercentLife,          ItemQuality.Legendary,  0.18f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ArcaneDamage,         ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ArcaneDamage,         ItemQuality.Legendary,  25.0f,  new string[] { "Moonlight Ward" }   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.FireDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.ColdDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.LightningDamage,      ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.HolyDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PhysicalDamage,       ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.PoisonDamage,         ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Amulet,      AffixType.Sockets,              ItemQuality.Legendary,  1.0f    ),

            /*-----------------------------------------------------------------------------------------------------
                                                            SHOULDERS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Intelligence,         ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Dexterity,            ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Strength,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Vitality,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.PercentLife,          ItemQuality.Rare,       0.12f   ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.BonusArmor,           ItemQuality.Rare,       347.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.MeteorDamage,         ItemQuality.Rare,       15.0f   ),

            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Intelligence,         ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Dexterity,            ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Strength,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.Vitality,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.PercentLife,          ItemQuality.Legendary,  0.15f   ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.BonusArmor,           ItemQuality.Legendary,  397.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Shoulders,   AffixType.MeteorDamage,         ItemQuality.Legendary,  15.0f   ),

            /*-----------------------------------------------------------------------------------------------------
                                                          CHEST ARMOR
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Intelligence,         ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Dexterity,            ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Strength,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Vitality,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.PercentLife,          ItemQuality.Rare,       0.12f   ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.BonusArmor,           ItemQuality.Rare,       545.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Sockets,              ItemQuality.Rare,       3.0f    ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.MeteorDamage,         ItemQuality.Rare,       15.0f   ),

            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Intelligence,         ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Dexterity,            ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Strength,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Vitality,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.02f,  new string[] { "Vyr's Astonishing Aura" }   ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.AttackSpeed,          ItemQuality.Legendary,  0.07f,  new string[] { "Tal Rasha's Relentless Pursuit" }   ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.PercentLife,          ItemQuality.Legendary,  0.15f   ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.BonusArmor,           ItemQuality.Legendary,  595.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.FireDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Cindercoat" }   ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.Sockets,              ItemQuality.Legendary,  3.0f    ),
            new MaxStatTableEntry(ItemSlot.Chest,       AffixType.MeteorDamage,         ItemQuality.Legendary,  15.0f   ),

            /*-----------------------------------------------------------------------------------------------------
                                                            GLOVES
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Intelligence,         ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Dexterity,            ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Strength,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Vitality,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.CriticalHitChance,    ItemQuality.Rare,       0.10f   ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.CriticalHitDamage,    ItemQuality.Rare,       0.50f   ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.AttackSpeed,          ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.BonusArmor,           ItemQuality.Rare,       347.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),

            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Intelligence,         ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Dexterity,            ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Strength,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.Vitality,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.10f   ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.CriticalHitDamage,    ItemQuality.Legendary,  0.50f   ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.AttackSpeed,          ItemQuality.Legendary,  0.07f   ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.BonusArmor,           ItemQuality.Legendary,  397.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.FireDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Magefist" } ),
            new MaxStatTableEntry(ItemSlot.Gloves,      AffixType.ColdDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Frostburn" } ),

            /*-----------------------------------------------------------------------------------------------------
                                                            BRACERS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Intelligence,         ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Dexterity,            ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Strength,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Vitality,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.CriticalHitChance,    ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.BonusArmor,           ItemQuality.Rare,       347.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ArcaneDamage,         ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.FireDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ColdDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.LightningDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.HolyDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PhysicalDamage,       ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PoisonDamage,         ItemQuality.Rare,       15.0f   ),

            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Intelligence,         ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Dexterity,            ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Strength,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.Vitality,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.06f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.AttackSpeed,          ItemQuality.Legendary,  0.07f,  new string[] { "Lacuni Prowlers", "Steady Strikers" }   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.BonusArmor,           ItemQuality.Legendary,  397.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ArcaneDamage,         ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.FireDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.ColdDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.LightningDamage,      ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.HolyDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PhysicalDamage,       ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.Bracers,     AffixType.PoisonDamage,         ItemQuality.Legendary,  20.0f   ),

            /*-----------------------------------------------------------------------------------------------------
                                                            BELT
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Intelligence,         ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Dexterity,            ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Strength,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Vitality,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.PercentLife,          ItemQuality.Rare,       0.12f   ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.BonusArmor,           ItemQuality.Rare,       347.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),

            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Intelligence,         ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Dexterity,            ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Strength,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.Vitality,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.CriticalHitDamage,    ItemQuality.Legendary,  0.50f,  new string[] { "The Witching Hour" }    ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.AttackSpeed,          ItemQuality.Legendary,  0.06f,  new string[] { "The Witching Hour", "Hellcat Waistguard", "Quick Draw Belt", "Fleeting Strap" } ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.PercentLife,          ItemQuality.Legendary,  0.15f   ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.BonusArmor,           ItemQuality.Legendary,  397.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.LightningResistance,  ItemQuality.Legendary,  200.0f, new string[] { "Thundergod's Vigor"}    ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Belt,        AffixType.LightningDamage,      ItemQuality.Legendary,  20.0f, new string[] { "Thundergod's Vigor"}    ),

            /*-----------------------------------------------------------------------------------------------------
                                                            PANTS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Intelligence,         ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Dexterity,            ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Strength,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Vitality,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.BonusArmor,           ItemQuality.Rare,       545.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Sockets,              ItemQuality.Rare,       2.0f    ),

            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Intelligence,         ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Dexterity,            ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Strength,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Vitality,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.AttackSpeed,          ItemQuality.Legendary,  0.07f,  new string[] { "Captain Crimson's Bowsprit" }   ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.PoisonDamage,         ItemQuality.Legendary,  20.0f, new string[] { "Swamp Land Waders" }   ),
            new MaxStatTableEntry(ItemSlot.Pants,       AffixType.Sockets,              ItemQuality.Legendary,  2.0f    ),

            /*-----------------------------------------------------------------------------------------------------
                                                            RINGS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Intelligence,         ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Dexterity,            ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Strength,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Vitality,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.CriticalHitChance,    ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.CriticalHitDamage,    ItemQuality.Rare,       0.50f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.AttackSpeed,          ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PercentLife,          ItemQuality.Rare,       0.12f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.BonusArmor,           ItemQuality.Rare,       347.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Sockets,              ItemQuality.Rare,       1.0f    ),

            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Intelligence,         ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Dexterity,            ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Strength,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Vitality,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.AverageDamage,        ItemQuality.Legendary,  130.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.06f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.CriticalHitDamage,    ItemQuality.Legendary,  0.50f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.AttackSpeed,          ItemQuality.Legendary,  0.07f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.AttackSpeed,          ItemQuality.Legendary,  0.09f,  new string[] { "Oculus Ring" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PercentLife,          ItemQuality.Legendary,  0.15f   ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.BonusArmor,           ItemQuality.Legendary,  397.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.ArcaneDamage,         ItemQuality.Legendary,  20.0f,  new string[] { "Stone of Jordan" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.FireDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Stone of Jordan" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.ColdDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Stone of Jordan" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.LightningDamage,      ItemQuality.Legendary,  20.0f,  new string[] { "Stone of Jordan" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.HolyDamage,           ItemQuality.Legendary,  20.0f,  new string[] { "Stone of Jordan" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PoisonDamage,         ItemQuality.Legendary,  20.0f,  new string[] { "Stone of Jordan" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.PhysicalDamage,       ItemQuality.Legendary,  20.0f,  new string[] { "Stone of Jordan" }  ),
            new MaxStatTableEntry(ItemSlot.Ring,        AffixType.Sockets,              ItemQuality.Legendary,  1.0f    ),

            /*-----------------------------------------------------------------------------------------------------
                                                            BOOTS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Intelligence,         ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Dexterity,            ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Strength,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Vitality,             ItemQuality.Rare,       425.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.BonusArmor,           ItemQuality.Rare,       347.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ArcaneTorrentDamage,  ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ArcaneOrbDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.DisintegrateDamage,   ItemQuality.Rare,       15.0f   ),

            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Intelligence,         ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Dexterity,            ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Strength,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.Vitality,             ItemQuality.Legendary,  500.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.AttackSpeed,          ItemQuality.Legendary,  0.07f,  new string[] { "Asheara's Tracks" } ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.BonusArmor,           ItemQuality.Legendary,  397.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ArcaneTorrentDamage,  ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.ArcaneOrbDamage,      ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.Boots,       AffixType.DisintegrateDamage,   ItemQuality.Legendary,  15.0f   ),

            /*-----------------------------------------------------------------------------------------------------
                                                            WEAPONS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Intelligence,         ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Dexterity,            ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Strength,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Vitality,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.CriticalHitChance,    ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.CriticalHitDamage,    ItemQuality.Rare,       0.50f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.AttackSpeed,          ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.PercentLife,          ItemQuality.Rare,       0.14f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.BonusArmor,           ItemQuality.Rare,       545.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneDamage,         ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.FireDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ColdDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.LightningDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Sockets,              ItemQuality.Rare,       1.0f    ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneTorrentDamage,  ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneOrbDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.DisintegrateDamage,   ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.MeteorDamage,         ItemQuality.Rare,       15.0f   ),

            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Intelligence,         ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Dexterity,            ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Strength,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Vitality,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.06f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.AttackSpeed,          ItemQuality.Legendary,  0.06f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.PercentLife,          ItemQuality.Legendary,  0.15f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.BonusArmor,           ItemQuality.Legendary,  595.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneDamage,         ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.FireDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ColdDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.LightningDamage,      ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.Sockets,              ItemQuality.Legendary,  1.0f    ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneTorrentDamage,  ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.ArcaneOrbDamage,      ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.DisintegrateDamage,   ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.MainHand,    AffixType.MeteorDamage,         ItemQuality.Legendary,  15.0f   ),

            /*-----------------------------------------------------------------------------------------------------
                                                            OFF-HANDS
            ------------------------------------------------------------------------------------------------------*/
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Intelligence,         ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Dexterity,            ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Strength,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Vitality,             ItemQuality.Rare,       625.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.CriticalHitChance,    ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.CriticalHitDamage,    ItemQuality.Rare,       0.50f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.AttackSpeed,          ItemQuality.Rare,       0.06f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.PercentLife,          ItemQuality.Rare,       0.14f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.BonusArmor,           ItemQuality.Rare,       545.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.AllResistances,       ItemQuality.Rare,       90.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.FireResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.HolyResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.PhysicalResistance,   ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ColdResistance,       ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.LightningResistance,  ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.PoisonResistance,     ItemQuality.Rare,       140.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneDamage,         ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.FireDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ColdDamage,           ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.LightningDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Sockets,              ItemQuality.Rare,       1.0f    ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneTorrentDamage,  ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneOrbDamage,      ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.DisintegrateDamage,   ItemQuality.Rare,       15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.MeteorDamage,         ItemQuality.Rare,       15.0f   ),

            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Intelligence,         ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Dexterity,            ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Strength,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Vitality,             ItemQuality.Legendary,  750.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.CriticalHitChance,    ItemQuality.Legendary,  0.06f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.AttackSpeed,          ItemQuality.Legendary,  0.06f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.PercentLife,          ItemQuality.Legendary,  0.15f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.BonusArmor,           ItemQuality.Legendary,  595.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.AllResistances,       ItemQuality.Legendary,  100.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.FireResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.HolyResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.PhysicalResistance,   ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ColdResistance,       ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.LightningResistance,  ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.PoisonResistance,     ItemQuality.Legendary,  160.0f  ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneDamage,         ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.FireDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ColdDamage,           ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.LightningDamage,      ItemQuality.Legendary,  20.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.Sockets,              ItemQuality.Legendary,  1.0f    ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneTorrentDamage,  ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.ArcaneOrbDamage,      ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.DisintegrateDamage,   ItemQuality.Legendary,  15.0f   ),
            new MaxStatTableEntry(ItemSlot.OffHand,     AffixType.MeteorDamage,         ItemQuality.Legendary,  15.0f   )

        };

        public MaxStatTableEntry this[int i]
        {
            get
            {
                return this.Table[i];
            }
        }
    }

    public class MaxStatTableEntry
    {
        public ItemSlot Slot;
        public AffixType Stat;
        public ItemQuality Quality;
        public float MaxValue;
        public string[] UniqueItems;

        public MaxStatTableEntry() { }

        public MaxStatTableEntry(ItemSlot slot, AffixType stat, ItemQuality quality, float max)
        {
            this.Slot = slot;
            this.Stat = stat;
            this.Quality = quality;
            this.MaxValue = max;
        }

        public MaxStatTableEntry(ItemSlot slot, AffixType stat, ItemQuality quality, float max, string[] uniqueItems)
        {
            this.Slot = slot;
            this.Stat = stat;
            this.Quality = quality;
            this.MaxValue = max;
            this.UniqueItems = uniqueItems;
        }
    }
}
