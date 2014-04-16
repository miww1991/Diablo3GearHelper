using System;
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
            new AffixTableEntry("{1} Resistance to All Elements",                           AffixQuality.Primary,   AffixType.AllResistances                ),
            new AffixTableEntry("{1} Fire Resistance",                                      AffixQuality.Secondary, AffixType.FireResistance                ),
            new AffixTableEntry("{1} Cold Resistance",                                      AffixQuality.Secondary, AffixType.ColdResistance                ),
            new AffixTableEntry("{1} Lightning Resistance",                                 AffixQuality.Secondary, AffixType.LightningResistance           ),
            new AffixTableEntry("{1} Arcane Resistance",                                    AffixQuality.Secondary, AffixType.ArcaneResistance              ),
            new AffixTableEntry("{1} Poison Resistance",                                    AffixQuality.Secondary, AffixType.PoisonResistance              ),
            new AffixTableEntry("{1} Holy Resistance",                                      AffixQuality.Secondary, AffixType.HolyResistance                ),
            new AffixTableEntry("{1} Physical Resistance",                                  AffixQuality.Secondary, AffixType.PhysicalResistance            ),

            // Elemental Damage Stats
            new AffixTableEntry("Arcane skills deal {1}% more damage.",                     AffixQuality.Primary,   AffixType.ArcaneDamage                  ),
            new AffixTableEntry("Fire skills deal {1}% more damage.",                       AffixQuality.Primary,   AffixType.FireDamage                    ),
            new AffixTableEntry("Cold skills deal {1}% more damage.",                       AffixQuality.Primary,   AffixType.ColdDamage                    ),
            new AffixTableEntry("Lightning skills deal {1}% more damage.",                  AffixQuality.Primary,   AffixType.LightningDamage               ),
            new AffixTableEntry("Holy skills deal {1}% more damage.",                       AffixQuality.Primary,   AffixType.HolyDamage                    ),
            new AffixTableEntry("Physical skills deal {1}% more damage.",                   AffixQuality.Primary,   AffixType.PhysicalDamage                ),
            new AffixTableEntry("Poison skills deal {1}% more damage.",                     AffixQuality.Primary,   AffixType.PoisonDamage                  ),

            // Sockets
            new AffixTableEntry("Need to Put Something Here",                               AffixQuality.Primary,   AffixType.Sockets                       ),

            // Wizard Skills
            new AffixTableEntry("Increases Arcane Torrent Damage by {1}% (Wizard Only)",    AffixQuality.Primary,   AffixType.ArcaneTorrentDamage           ),
            new AffixTableEntry("Increases Arcane Orb Damage by {1}% (Wizard Only)",        AffixQuality.Primary,   AffixType.ArcaneOrbDamage               ),
            new AffixTableEntry("Increases Disintegrate Damage by {1}% (Wizard Only)",      AffixQuality.Primary,   AffixType.DisintegrateDamage            ),
            new AffixTableEntry("Increases Black Hole Damage by {1}% (Wizard Only)",        AffixQuality.Primary,   AffixType.BlackHoleDamage               )

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
