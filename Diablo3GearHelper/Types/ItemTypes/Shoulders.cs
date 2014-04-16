using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Shoulders : Item
    {
        public int BaseArmor { get; protected set; }

        public Shoulders() : base(ItemSlot.Shoulders) { }

        public override string ToString()
        {
            return "Shoulders: " + this.Name;
        }
    }
}
