using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Pants : Item
    {
        public int BaseArmor { get; protected set; }

        public Pants() : base(ItemSlot.Pants) { }

        public override string ToString()
        {
            return "Pants: " + this.Name;
        }
    }
}
