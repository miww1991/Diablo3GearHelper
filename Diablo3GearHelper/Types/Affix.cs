﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public enum AffixQuality
    {
        Primary,
        Secondary
    }

    public class Affix
    {
        /// <summary>
        /// The quality of the Affix (either Primary or Secondary)
        /// </summary>
        public AffixQuality AffixQuality { get; set; }

        /// <summary>
        /// The type of Affix
        /// </summary>
        public AffixType AffixType { get; set; }

        /// <summary>
        /// Is this an Enchanted Affix?
        /// </summary>
        public bool Enchanted { get; set; }

        /// <summary>
        /// The value associated with the Affix
        /// </summary>
        public float Value { get; set; }

        public Affix() { }

        public Affix(AffixQuality quality, AffixType type, bool enchanted, float value)
        {
            this.AffixQuality = quality;
            this.AffixType = type;
            this.Enchanted = enchanted;
            this.Value = value;
        }
    }
}
