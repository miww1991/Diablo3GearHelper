using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Diagnostics;

namespace Diablo3GearHelper.Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemQuality
    {
        [EnumMember(Value = "white")]
        Common,
        [EnumMember(Value = "blue")]
        Magic,
        [EnumMember(Value = "yellow")]
        Rare,
        [EnumMember(Value = "green")]
        Set,
        [EnumMember(Value = "orange")]
        Legendary,

        ItemQualityCount
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemSlot
    {
        [EnumMember(Value = "head")]
        Helm,
        [EnumMember(Value = "torso")]
        Chest,
        [EnumMember(Value = "legs")]
        Pants,
        [EnumMember(Value = "feet")]
        Boots,
        [EnumMember(Value = "hands")]
        Gloves,
        [EnumMember(Value = "shoulders")]
        Shoulders,
        [EnumMember(Value = "bracers")]
        Bracers,
        [EnumMember(Value = "mainHand")]
        MainHand,
        [EnumMember(Value = "offHand")]
        OffHand,
        [EnumMember(Value = "waist")]
        Belt,
        [EnumMember(Value = "leftFinger")]
        LeftRing,
        [EnumMember(Value = "rightFinger")]
        RightRing,
        [EnumMember(Value = "neck")]
        Amulet,

        ItemSlotCount
    }

    public class Item
    {
        /// <summary>
        /// Is the item Enchanted?
        /// </summary>
        public bool Enchanted
        {
            get
            {
                return (PrimaryAffixes.Any(affix => affix.Enchanted == true) || SecondaryAffixes.Any(affix => affix.Enchanted == true));
            }
        }

        /// <summary>
        /// The Id of the Item
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; protected set; }

        /// <summary>
        /// The Item Level of the Item
        /// </summary>
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; protected set; }

        private List<Gem> _gems = new List<Gem>();

        /// <summary>
        /// The Gems in the Item
        /// </summary>
        public List<Gem> Gems
        {
            get
            {
                return _gems;
            }
            set
            {
                this._gems = value;
            }
        }

        /// <summary>
        /// The Name of the Item
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; protected set; }

        private List<Affix> _primaryAffixes = new List<Affix>();

        /// <summary>
        /// The Primary Affixes on the Item
        /// </summary>
        public List<Affix> PrimaryAffixes
        {
            get
            {
                return _primaryAffixes;
            }
            set
            {
                this._primaryAffixes = value;
            }
        }

        /// <summary>
        /// The Quality of the Item
        /// </summary>
        [JsonProperty("displayColor")]
        public ItemQuality Quality { get; protected set; }

        private List<Affix> _secondaryAffixes = new List<Affix>();

        /// <summary>
        /// The Secondary Affixes on the Item
        /// </summary>
        public List<Affix> SecondaryAffixes
        {
            get
            {
                return _secondaryAffixes;
            }
            set
            {
                this._secondaryAffixes = value;
            }
        }

        /// <summary>
        /// The Slot the Item goes in
        /// </summary>
        public ItemSlot Slot { get; protected set; }

        public Item(ItemSlot itemSlot)
        {
            this.Slot = itemSlot;
        }

        /// <summary>
        /// Retrieves the amount of the specified affix on the item
        /// </summary>
        /// <param name="affixType">The affix to retrieve values for</param>
        /// <returns>The amount of the specified stat on the item</returns>
        public float GetStatValue(AffixType affixType)
        {
            int value = 0;

            // Get Primary Stat Values from Gear Stats
            if (this.PrimaryAffixes.Any(affix => affix.AffixType == affixType))
            {
                value += (int)this.PrimaryAffixes.Where(affix => affix.AffixType == affixType).FirstOrDefault().Value;
            }

            // Get Primary Stat Values from Gems
            foreach (Gem gem in this.Gems)
            {
                if (gem.StatType == affixType)
                {
                    value += (int)gem.Value;
                }
            }

            return value;
        }
    }
}
