using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;

namespace Diablo3GearHelper.Types
{
    public class Gear : IEnumerable
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

        /// <summary>
        /// Gets the total amount of the specified stat on all the gear
        /// </summary>
        /// <param name="affixType">The stat to get values for</param>
        /// <returns>The total value of the specified stat on the gear set</returns>
        public float GetStatTotal(AffixType affixType)
        {
            float total = 0;
            foreach (Item item in this)
            {
                if (item.GetType() == typeof(Weapon) && affixType == AffixType.AverageDamage)
                {
                    total += (item as Weapon).AverageDamage;
                }
                else if (affixType == AffixType.Armor)
                {
                    total += item.BaseArmor;
                }
                else if (item != null)
                {
                    total += item.GetStatValue(affixType);
                }
            }
            return total;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this.Helm;
            yield return this.Amulet;
            yield return this.Shoulders;
            yield return this.Gloves;
            yield return this.Chest;
            yield return this.Bracers;
            yield return this.Belt;
            yield return this.LeftRing;
            yield return this.RightRing;
            yield return this.Pants;
            yield return this.Boots;
            yield return this.MainHand;
            yield return this.OffHand;
        }
    }
}
