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
        public Item Helm { get; set; }

        public Item Amulet { get; set; }

        public Item Shoulders { get; set; }

        public Item Gloves { get; set; }

        public Item Chest { get; set; }

        public Item Bracers { get; set; }

        public Item Belt { get; set; }

        public Item LeftFinger { get; set; }

        public Item RightFinger { get; set; }

        public Item Pants { get; set; }

        public Item Boots { get; set; }

        public Item MainHand { get; set; }

        public Item OffHand { get; set; }

        public Gear()
        {

        }
    }
}
