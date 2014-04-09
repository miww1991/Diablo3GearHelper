using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Belt : Item
    {
        public int Armor { get; set; }

        public Belt() : base(ItemSlot.Belt) { }
    }
}
