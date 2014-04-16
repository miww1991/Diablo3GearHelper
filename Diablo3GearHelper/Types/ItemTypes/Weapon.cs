using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Diablo3GearHelper.Types
{
    public class Weapon : Item
    {
        public float AverageDamage
        {
            get
            {
                return (MinDamage + MaxDamage) / 2;
            }
        }

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

        [JsonProperty("ignoreMe4")]
        public int MaxDamage { get; set; }

        [JsonProperty("ignoreMe3")]
        public int MinDamage { get; set; }

        public Weapon(ItemSlot slot) : base(slot) { }

        public override string ToString()
        {
            return "Weapon: " + this.Name;
        }
    }
}
