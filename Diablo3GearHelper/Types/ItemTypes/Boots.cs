using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Boots : Item
    {
        public int BaseArmor { get; protected set; }

        public Boots() : base(ItemSlot.Boots) { }
    }
}
