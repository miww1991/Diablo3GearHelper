using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Bracers : Item
    {
        public int BaseArmor { get; protected set; }

        public Bracers() : base(ItemSlot.Bracers) { }

        public override string ToString()
        {
            return "Bracers: " + this.Name;
        }
    }
}
