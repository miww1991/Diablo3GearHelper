using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Helm : Item
    {
        public int BaseArmor { get; protected set; }

        public Helm() : base(ItemSlot.Helm) { }

        public override string ToString()
        {
            return "Helm: " + this.Name;
        }
    }
}
