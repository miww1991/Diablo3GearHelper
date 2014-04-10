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
            new AffixTableEntry("{1} Intelligence", AffixQuality.Primary,   AffixType.Intelligence  ),
            new AffixTableEntry("{1} Dexterity",    AffixQuality.Primary,   AffixType.Dexterity     ),
            new AffixTableEntry("{1} Strength",     AffixQuality.Primary,   AffixType.Strength      ),
            new AffixTableEntry("{1} Vitality",     AffixQuality.Primary,   AffixType.Vitality      )
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
