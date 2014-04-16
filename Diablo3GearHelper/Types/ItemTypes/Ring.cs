using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Ring : Item
    {
        public Ring(ItemSlot slot) : base(slot) { }

        public override string ToString()
        {
            return "Ring: " + this.Name;
        }
    }
}
