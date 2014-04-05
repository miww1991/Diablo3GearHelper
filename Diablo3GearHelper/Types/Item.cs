using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public enum ItemQuality
    {
        Common,
        Magic,
        Rare,
        Set,
        Legendary
    }

    public class Item
    {
        /// <summary>
        /// The Id of the Item
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// The Item Level of the Item
        /// </summary>
        public int ItemLevel { get; protected set; }

        /// <summary>
        /// The Name of the Item
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The Primary Affixes on the Item
        /// </summary>
        public Affix[] PrimaryAffixes { get; set; }

        /// <summary>
        /// The Quality of the Item
        /// </summary>
        public ItemQuality Quality { get; protected set; }

        /// <summary>
        /// The Secondary Affixes on the Item
        /// </summary>
        public Affix[] SecondaryAffixes { get; set; }
    }
}
