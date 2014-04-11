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
        /// Retrieves the amount of the specified class' primary stat
        /// </summary>
        /// <param name="classType">The type of class to retrieve the primary stat for</param>
        /// <returns>The amount of primary stat on the item</returns>
        public int GetPrimaryStatValue(ClassType classType)
        {
            int value = 0;

            if (classType == ClassType.Barbarian || classType == ClassType.Crusader)
            {
                if (this.PrimaryAffixes.Any(affix => affix.AffixType == AffixType.Strength))
                {
                    value += (int)this.PrimaryAffixes.Where(affix => affix.AffixType == AffixType.Strength).FirstOrDefault().Value;
                }
            }
            else if (classType == ClassType.WitchDoctor || classType == ClassType.Wizard)
            {
                if (this.PrimaryAffixes.Any(affix => affix.AffixType == AffixType.Intelligence))
                {
                    value += (int)this.PrimaryAffixes.Where(affix => affix.AffixType == AffixType.Intelligence).FirstOrDefault().Value;
                }
            }
            else
            {
                Debug.Assert(classType == ClassType.Monk || classType == ClassType.DemonHunter);

                if (this.PrimaryAffixes.Any(affix => affix.AffixType == AffixType.Dexterity))
                {
                    value += (int)this.PrimaryAffixes.Where(affix => affix.AffixType == AffixType.Dexterity).FirstOrDefault().Value;
                }
            }

            return value;
        }
    }
}
