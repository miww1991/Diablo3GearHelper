using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3GearHelper.Types;

namespace Diablo3GearHelper.Data
{
    public class SkillLookupTable
    {
        private static SkillLookupTable instance;

        public static SkillLookupTable Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SkillLookupTable();
                }
                return instance;
            }
        }

        public readonly SkillLookupTableEntry[] Table =
        {
            new SkillLookupTableEntry("Arcane Torrent", AffixType.ArcaneTorrentDamage,  AffixType.ArcaneDamage      ),
            new SkillLookupTableEntry("Disintegrate",   AffixType.DisintegrateDamage,   AffixType.ArcaneDamage      ),
            new SkillLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.ArcaneDamage      ),
            new SkillLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.ColdDamage,       "Frozen Orb" ),
            new SkillLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.FireDamage,       "Scorch" ),
            new SkillLookupTableEntry("Arcane Orb",     AffixType.ArcaneOrbDamage,      AffixType.LightningDamage,  "Spark" ),
            new SkillLookupTableEntry("Meteor",         AffixType.MeteorDamage,         AffixType.ArcaneDamage,     "Star Pact" ),
            new SkillLookupTableEntry("Meteor",         AffixType.MeteorDamage,         AffixType.ColdDamage,       "Comet" ),
            new SkillLookupTableEntry("Meteor",         AffixType.MeteorDamage,         AffixType.LightningDamage,  "Lightning Bind"    )
        };
    }

    public class SkillLookupTableEntry
    {
        public string Name { get; private set; }

        public string Rune { get; private set; }

        public AffixType SpellDamageAffix { get; private set; }

        public AffixType SpellSchoolDamageAffix { get; private set; }

        public SkillLookupTableEntry(string name, AffixType dmg, AffixType school, string rune = null)
        {
            this.Name = name;
            this.Rune = rune;
            this.SpellDamageAffix = dmg;
            this.SpellSchoolDamageAffix = school;
        }
    }
}
