﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public class Boots : Item
    {
        public Boots() : base(ItemSlot.Boots) { }

        public override string ToString()
        {
            return "Boots: " + this.Name;
        }
    }
}
