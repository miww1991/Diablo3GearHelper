using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Belt : Item
    {
        public int BaseArmor { get; protected set; }

        public Belt() : base(ItemSlot.Belt) { }

        public override string ToString()
        {
            return "Belt: " + this.Name;
        }
    }
}
