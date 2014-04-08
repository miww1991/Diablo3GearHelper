using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Diablo3GearHelper.Types
{
    public class Gear
    {
        public Helm Helm { get; set; }

        public Amulet Amulet { get; set; }

        public Shoulders Shoulders { get; set; }

        public Gloves Gloves { get; set; }

        public Chest Chest { get; set; }

        public Bracers Bracers { get; set; }

        public Belt Belt { get; set; }

        public Ring LeftRing { get; set; }

        public Ring RightRing { get; set; }

        public Pants Pants { get; set; }

        public Boots Boots { get; set; }

        public Weapon MainHand { get; set; }

        public Item OffHand { get; set; }

        public Gear()
        {

        }
    }
}
