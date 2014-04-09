using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Diablo3GearHelper.Types
{
    public class Weapon : Item
    {
        [JsonProperty("ignoreMe1")]
        public float AttacksPerSecond { get; set; }

        [JsonProperty("ignoreMe2")]
        public int DPS
        {
            get
            {
                return (int)Math.Round(AttacksPerSecond * ((MinDamage + MaxDamage) / 2));
            }
        }

        [JsonProperty("ignoreMe3")]
        public int MinDamage;

        [JsonProperty("ignoreMe4")]
        public int MaxDamage { get; set; }

        public Weapon(ItemSlot slot) : base(slot) { }
    }
}
