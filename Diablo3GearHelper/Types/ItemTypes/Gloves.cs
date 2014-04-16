using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Gloves : Item
    {
        public int BaseArmor { get; protected set; }

        public Gloves() : base(ItemSlot.Gloves) { }

        public override string ToString()
        {
            return "Gloves: " + this.Name;
        }
    }
}
