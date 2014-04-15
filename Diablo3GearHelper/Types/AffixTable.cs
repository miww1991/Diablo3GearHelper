﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class AffixLookupTable
    {
        private static AffixLookupTable instance;

        public static AffixLookupTable Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AffixLookupTable();
                }
                return instance;
            }
        }

        public readonly AffixTableEntry[] Table =
        {
            // Primary Stats
            new AffixTableEntry("{1} Intelligence",                                         AffixQuality.Primary,   AffixType.Intelligence                  ),
            new AffixTableEntry("{1} Dexterity",                                            AffixQuality.Primary,   AffixType.Dexterity                     ),
            new AffixTableEntry("{1} Strength",                                             AffixQuality.Primary,   AffixType.Strength                      ),
            new AffixTableEntry("{1} Vitality",                                             AffixQuality.Primary,   AffixType.Vitality                      ),

            // Offensive Stats
            new AffixTableEntry("Critical Hit Chance Increased by {1}%",                    AffixQuality.Primary,   AffixType.CriticalHitChance             ),
            new AffixTableEntry("Critical Hit Damage Increased by {1}%",                    AffixQuality.Primary,   AffixType.CriticalHitDamage             ),
            new AffixTableEntry("Attack Speed Increased by {1}%",                           AffixQuality.Primary,   AffixType.AttackSpeed                   ),

            // Defensive Stats
            new AffixTableEntry("{1}% Life",                                                AffixQuality.Primary,   AffixType.PercentLife                   ),
            new AffixTableEntry("{1} Armor",                                                AffixQuality.Primary,   AffixType.BonusArmor                    ),
            new AffixTableEntry("Ranged and melee attackers take {1} damage per hit",       AffixQuality.Secondary, AffixType.Thorns                        ),
            new AffixTableEntry("{1} Resistance to All Elements",                           AffixQuality.Primary,   AffixType.AllResistances                ),
            new AffixTableEntry("{1} Fire Resistance",                                      AffixQuality.Secondary, AffixType.FireResistance                ),
            new AffixTableEntry("{1} Cold Resistance",                                      AffixQuality.Secondary, AffixType.ColdResistance                ),
            new AffixTableEntry("{1} Lightning Resistance",                                 AffixQuality.Secondary, AffixType.LightningResistance           ),
            new AffixTableEntry("{1} Arcane Resistance",                                    AffixQuality.Secondary, AffixType.ArcaneResistance              ),
            new AffixTableEntry("{1} Poison Resistance",                                    AffixQuality.Secondary, AffixType.PoisonResistance              ),
            new AffixTableEntry("Reduces damage from ranged attacks by {1}%.",              AffixQuality.Secondary, AffixType.ReducedDamageFromRangedAttacks),

            // Elemental Damage Stats
            new AffixTableEntry("Arcane skills deal {1}% more damage.",                     AffixQuality.Primary,   AffixType.ArcaneDamage                  ),
            new AffixTableEntry("Fire skills deal {1}% more damage.",                       AffixQuality.Primary,   AffixType.FireDamage                    ),
            new AffixTableEntry("Cold skills deal {1}% more damage.",                       AffixQuality.Primary,   AffixType.ColdDamage                    ),
            new AffixTableEntry("Lightning skills deal {1}% more damage.",                  AffixQuality.Primary,   AffixType.LightningDamage               ),

            // Healing Stats
            new AffixTableEntry("{1} Life after Each Kill",                                 AffixQuality.Secondary, AffixType.LifePerKill                   ),
            new AffixTableEntry("Regenerates {1} Life per Second",                          AffixQuality.Primary,   AffixType.LifePerSecond                 ),
            new AffixTableEntry("Health Globes and Potions Grant {1} Life.",                AffixQuality.Secondary, AffixType.HealthGlobeAndPotionExtraLife ),

            // Utility Stats
            new AffixTableEntry("Increases Gold and Health Pickup by {1} Yards.",           AffixQuality.Secondary, AffixType.GoldPickupRadius              ),
            new AffixTableEntry("Increases Bonus Experience by {1}%",                       AffixQuality.Secondary, AffixType.BonusExperiencePercent        ),
            new AffixTableEntry("{1}% Movement Speed",                                      AffixQuality.Primary,   AffixType.MovementSpeed                 ),
            new AffixTableEntry("{1}% Extra Gold from Monsters",                            AffixQuality.Secondary, AffixType.ExtraGoldFromMonsters         ),

            // Sockets
            new AffixTableEntry("Need to Put Something Here",                               AffixQuality.Primary,   AffixType.Sockets                       ),

            // Wizard Skills
            new AffixTableEntry("Increases Arcane Torrent Damage by {1}% (Wizard Only)",    AffixQuality.Primary,   AffixType.ArcaneTorrentDamage           ),
            new AffixTableEntry("Increases Arcane Orb Damage by {1}% (Wizard Only)",        AffixQuality.Primary,   AffixType.ArcaneOrbDamage               ),
            new AffixTableEntry("Increases Disintegrate Damage by {1}% (Wizard Only)",      AffixQuality.Primary,   AffixType.DisintegrateDamage            ),
            new AffixTableEntry("Increases Black Hole Damage by {1}% (Wizard Only)",        AffixQuality.Primary,   AffixType.BlackHoleDamage               ),

            // Wizard Utilities
            new AffixTableEntry("Critical Hits grant {1} Arcane Power (Wizard Only)",       AffixQuality.Primary,   AffixType.ArcanePowerOnCrit             ),
            new AffixTableEntry("{1} Maximum Arcane Power (Wizard Only)",                   AffixQuality.Secondary, AffixType.MaximumArcanePower            ),

            // Miscellaneous
            new AffixTableEntry("Level Requirement Reduced by {1}",                         AffixQuality.Secondary, AffixType.ReducedLevelRequirement       ),
            new AffixTableEntry("Ignores Durability Loss",                                  AffixQuality.Secondary, AffixType.IgnoreDurabilityloss          ),
            new AffixTableEntry("{1}% Damage to Demons",                                    AffixQuality.Secondary, AffixType.PercentDamageToDemons         ),
            new AffixTableEntry("{1}% Chance to Knockback on Hit",                          AffixQuality.Secondary, AffixType.ChanceToKnockbackOnHit        ),
            new AffixTableEntry("{1}% Chance to Immobilize on Hit",                         AffixQuality.Secondary, AffixType.ChanceToImmobilizeOnHit       )
        };

        public AffixTableEntry this[int i]
        {
            get
            {
                return this.Table[i];
            }
        }
    }

    public class AffixTableEntry
    {
        public string DisplayString { get; private set; }

        public AffixQuality Quality { get; private set; }

        public AffixType Type { get; private set; }

        public AffixTableEntry() { }

        public AffixTableEntry(string displayString, AffixQuality quality, AffixType type)
        {
            this.DisplayString = displayString;
            this.Quality = quality;
            this.Type = type;
        }
    }
}