using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3GearHelper.Types;

namespace Diablo3GearHelper.Data
{
    public class SpellLookupTable
    {
        private static SpellLookupTable instance;

        public static SpellLookupTable Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SpellLookupTable();
                }
                return instance;
            }
        }

        public readonly SpellLookupTableEntry[] Table =
        {
            new SpellLookupTableEntry("Arcane Torrent", AffixType.ArcaneTorrentDamage,  AffixType.ArcaneDamage      ),
            new SpellLookupTableEntry("Disintegrate",   AffixType.DisintegrateDamage,   AffixType.ArcaneDamage      ),
            new SpellLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.ArcaneDamage      ),
            new SpellLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.ColdDamage,       "Frozen Orb" ),
            new SpellLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.FireDamage,       "Scorch" ),
            new SpellLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.LightningDamage,  "Spark" ),
            new SpellLookupTableEntry("Meteor",         AffixType.MeteorDamage,         AffixType.ArcaneDamage,     "Star Pact" ),
            new SpellLookupTableEntry("Meteor",         AffixType.MeteorDamage,         AffixType.ColdDamage,       "Comet" ),
            new SpellLookupTableEntry("Meteor",         AffixType.MeteorDamage,         AffixType.LightningDamage,  "Lightning Bind"    )
        };
    }

    public class SpellLookupTableEntry
    {
        public string Name { get; private set; }

        public string Rune { get; private set; }

        public AffixType SpellDamageAffix { get; private set; }

        public AffixType SpellSchoolDamageAffix { get; private set; }

        public SpellLookupTableEntry(string name, AffixType dmg, AffixType school, string rune = null)
        {
            this.Name = name;
            this.Rune = rune;
            this.SpellDamageAffix = dmg;
            this.SpellSchoolDamageAffix = school;
        }
    }
}
