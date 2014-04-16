using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Chest : Item
    {
        public int BaseArmor { get; protected set; }

        public Chest() : base(ItemSlot.Chest) { }

        public override string ToString()
        {
            return "Chest: " + this.Name;
        }
    }
}
