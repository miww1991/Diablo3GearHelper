using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Gem
    {
        /// <summary>
        /// The Name of the Gem
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The Type of Stat on the Gem
        /// </summary>
        public AffixType StatType { get; protected set; }

        /// <summary>
        /// The Value associated with the Gem
        /// </summary>
        public float Value { get; protected set; }

        public Gem(string name, AffixType statType, float value)
        {
            this.Name = name;
            this.StatType = statType;
            this.Value = value;
        }
    }
}
