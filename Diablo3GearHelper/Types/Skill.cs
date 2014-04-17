using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Skill
    {
        public AffixType? BonusSkillDamageAffix { get; private set; }

        public string Name { get; private set; }

        public string Rune { get; private set; }

        public AffixType? SkillDamageType { get; private set; }

        public Skill(string name, AffixType? skillDmgType = null, string rune = null, AffixType? bonusSkill = null)
        {
            this.Name = name;
            this.SkillDamageType = skillDmgType;
            this.Rune = rune;
            this.BonusSkillDamageAffix = bonusSkill;
        }
    }
}
