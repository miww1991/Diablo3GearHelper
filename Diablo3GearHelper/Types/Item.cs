﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        /// <summary>
        /// The Primary Affixes on the Item
        /// </summary>
        public List<Affix> PrimaryAffixes { get; set; }

        /// <summary>
        /// The Quality of the Item
        /// </summary>
        [JsonProperty("displayColor")]
        public ItemQuality Quality { get; protected set; }

        /// <summary>
        /// The Secondary Affixes on the Item
        /// </summary>
        public List<Affix> SecondaryAffixes { get; set; }

        /// <summary>
        /// The Slot the Item goes in
        /// </summary>
        public ItemSlot Slot { get; protected set; }

        public Item(ItemSlot itemSlot)
        {
            this.Slot = itemSlot;
        }
    }
}
