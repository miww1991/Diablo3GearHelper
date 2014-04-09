using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public enum AffixType
    {
        Primary,
        Secondary
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
