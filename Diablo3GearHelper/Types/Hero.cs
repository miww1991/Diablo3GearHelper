using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Diablo3GearHelper.Types
{
    /// <summary>
    /// The various Classes in Diablo 3
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClassType
    {
        [EnumMember(Value = "barbarian")]
        Barbarian,
        [EnumMember(Value = "crusader")]
        Crusader,
        [EnumMember(Value = "demon-hunter")]
        DemonHunter,
        [EnumMember(Value = "monk")]
        Monk,
        [EnumMember(Value = "witch-doctor")]
        WitchDoctor,
        [EnumMember(Value = "wizard")]
        Wizard,

        ClassCount
    }

    /// <summary>
    /// The various Genders in Diablo 3
    /// </summary>
    public enum HeroGender
    {
        Male,
        Female,

        GenderCount
    }

    public class Hero
    {
        /// <summary>
        /// An array of strings that correlate with the classes in Diablo 3.
        /// Indexes must match up with the classes enumeration
        /// </summary>
        private readonly string[] _classStrings =
        {
            "Barbarian", "Crusader", "Demon Hunter", "Monk", "Witch Doctor",
            "Wizard", "Invalid Class"
        };

        private static readonly Dictionary<string, AffixType> SkillToAffixMap = new Dictionary<string, AffixType>
        {
            {"Arcane Torrent", AffixType.ArcaneTorrentDamage},
            {"Arcane Orb", AffixType.ArcaneOrbDamage},
            {"Disintegrate", AffixType.DisintegrateDamage},
            {"Meteor", AffixType.MeteorDamage}
        };

        /// <summary>
        /// The skills of the hero
        /// Note: This will later be updated to be something other than strings
        /// </summary>
        public string[] ActiveSkills { get; set; }

        /// <summary>
        /// The Hero's Total Attacks Per Second
        /// </summary>
        public float AttacksPerSecond
        {
            get
            {
                return this.Gear.MainHand.AttacksPerSecond * (1 + this.GetTotalStat(AffixType.AttackSpeed));
            }
        }

        public int BuffedDamage
        {
            get
            {
                return this.CalculatedBuffedHeroDamage();
            }
        }

        /// <summary>
        /// The Hero's Class
        /// </summary>
        [JsonProperty("class")]
        public ClassType Class { get; private set; }

        /// <summary>
        /// A string representing the Hero's Class
        /// </summary>
        public string ClassString
        {
            get { return _classStrings[(int) this.Class]; }
        }

        /// <summary>
        /// The Hero's Critical Hit Chance
        /// </summary>
        public float CriticalHitChance
        {
            get
            {
                return this.GetTotalStat(AffixType.CriticalHitChance) + 0.05f;
            }
        }

        /// <summary>
        /// The Hero's Critical Hit Damage
        /// </summary>
        public float CriticalHitDamage
        {
            get
            {
                return this.GetTotalStat(AffixType.CriticalHitDamage) + 0.5f;
            }
        }

        /// <summary>
        /// The Hero's Damage
        /// </summary>
        public int Damage
        {
            get
            {
                return CalculateHeroDamage
                    (
                    this.PrimaryStat,
                    this.CriticalHitChance,
                    this.CriticalHitDamage,
                    this.AttacksPerSecond,
                    this.GetTotalStat(AffixType.AverageDamage)
                    );
            }
        }

        private Gear _gear = new Gear();

        /// <summary>
        /// The Hero's Gear
        /// </summary>
        public Gear Gear
        {
            get
            {
                return _gear;
            }
            set
            {
                this._gear = value;
            }
        }

        /// <summary>
        /// The gender of the Hero
        /// </summary>
        //[JsonProperty("gender")]
        public HeroGender Gender { get; private set; }

        /// <summary>
        /// The Hero's Health
        /// </summary>
        public int Health
        {
            get
            {
                return (int)Math.Round(((this.GetTotalStat(AffixType.Vitality) * 80) + 316) * (1 + this.GetTotalStat(AffixType.PercentLife)));
            }
        }

        /// <summary>
        /// The Id of the Hero
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Indicates whether this Hero is dead
        /// </summary>
        public bool IsDead { get; private set; }

        /// <summary>
        /// Indicates whether this is a Hardcore Hero
        /// </summary>
        public bool IsHardcore { get; private set; }

        /// <summary>
        /// Date last updated in seconds since epoch
        /// </summary>
        [JsonProperty("last-updated")]
        private int _lastUpdatedEpoch;

        /// <summary>
        /// The last time this Hero was updated
        /// </summary>
        public DateTime LastUpdated
        {
            get
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this._lastUpdatedEpoch);
            }
        }

        /// <summary>
        /// The Level of the Hero
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// The name of the Hero
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The paragon level of the Hero
        /// </summary>
        public int ParagonLevel { get; private set; }

        /// <summary>
        /// The skills of the hero
        /// Note: This will later be updated to be something other than strings
        /// </summary>
        public string[] PassiveSkills { get; set; }

        /// <summary>
        /// The Hero's Primary Stat
        /// </summary>
        public int PrimaryStat
        {
            get
            {
                return this.GetTotalPrimaryStat();
            }
        }

        /// <summary>
        /// The Hero's Primary Stat Type
        /// </summary>
        public AffixType PrimaryStatType
        {
            get
            {
                if (this.Class == ClassType.Barbarian || this.Class == ClassType.Crusader)
                {
                    return AffixType.Strength;
                }
                else if (this.Class == ClassType.WitchDoctor || this.Class == ClassType.Wizard)
                {
                    return AffixType.Intelligence;
                }
                else
                {
                    Debug.Assert(this.Class == ClassType.DemonHunter || this.Class == ClassType.Monk);

                    return AffixType.Dexterity;
                }
            }
        }

        /// <summary>
        /// The runes for the hero's skills. These must match up with the Skills indexes.
        /// Note: This will later be updated to be something other than strings
        /// </summary>
        public string[] Runes { get; set; }

        /// <summary>
        /// Constructs a Hero Object
        /// </summary>
        public Hero(string name, int id, int level, bool isHardcore, int paragonLevel, HeroGender gender, bool isDead, ClassType charClass, int lastUpdated)
        {
            this.Name = name;
            this.Id = id;
            this.Level = level;
            this.IsHardcore = isHardcore;
            this.ParagonLevel = paragonLevel;
            this.Gender = gender;
            this.IsDead = isDead;
            this.Class = charClass;
            this._lastUpdatedEpoch = lastUpdated;
            this.ActiveSkills = new string[6];
            this.PassiveSkills = new string[4];
            this.Runes = new string[6];
        }

        public override string ToString()
        {
            string name = this.Name + " - Level " + this.Level + " " + this.ClassString;

            if (this.IsHardcore)
            {
                name += " (Hardcore)";
            }

            return name;
        }

        public int GetTotalPrimaryStat()
        {
            int value = (int)this.GetTotalStat(this.PrimaryStatType);
            value += 10; // Base Primary Stat
            value += (this.Level * 3); // Points per level

            return value;
        }

        /// <summary>
        /// Retrieves the total amount of the specified stat on all the gear
        /// </summary>
        /// <param name="statToGet">The stat to total</param>
        /// <returns>The total amount of the stat on all the gear</returns>
        public float GetTotalStat(AffixType statToGet)
        {
            float value = this.Gear.GetStatTotal(statToGet);

            if (statToGet == AffixType.Vitality)
            {
                value += (this.Level * 2) + 7;
            }

            return value;
        }

        public float CalculateStatWeight(AffixType statToCalculate)
        {
            int newDamage = 0;
            float weight = 0;

            switch (statToCalculate)
            {
                // Intentional fall through since all are primary stats
                case AffixType.Intelligence:
                case AffixType.Strength:
                case AffixType.Dexterity:
                    newDamage = CalculateHeroDamage
                                    (
                                    this.PrimaryStat + 1,
                                    this.CriticalHitChance,
                                    this.CriticalHitDamage,
                                    this.AttacksPerSecond,
                                    this.GetTotalStat(AffixType.AverageDamage)
                                    );
                    weight = newDamage - this.Damage;

                    break;

                case AffixType.CriticalHitChance:
                    newDamage = CalculateHeroDamage
                                    (
                                    this.PrimaryStat,
                                    this.CriticalHitChance + 0.01f,
                                    this.CriticalHitDamage,
                                    this.AttacksPerSecond,
                                    this.GetTotalStat(AffixType.AverageDamage)
                                    );
                    weight = newDamage - this.Damage;

                    break;

                case AffixType.CriticalHitDamage:
                    newDamage = CalculateHeroDamage
                                    (
                                    this.PrimaryStat,
                                    this.CriticalHitChance,
                                    this.CriticalHitDamage + 0.01f,
                                    this.AttacksPerSecond,
                                    this.GetTotalStat(AffixType.AverageDamage)
                                    );
                    weight = newDamage - this.Damage;

                    break;

                case AffixType.AttackSpeed:
                    newDamage = CalculateHeroDamage
                                    (
                                    this.PrimaryStat,
                                    this.CriticalHitChance,
                                    this.CriticalHitDamage,
                                    this.Gear.MainHand.AttacksPerSecond * (1.01f + this.GetTotalStat(AffixType.AttackSpeed)), // 1.0f base attack speed + 1% attack speed = 1.01
                                    this.GetTotalStat(AffixType.AverageDamage)
                                    );
                    weight = newDamage - this.Damage;

                    break;
                default:
                    throw new NotImplementedException();
            }

            return weight;
        }

        /// <summary>
        /// Calculates the Hero's Damage
        /// </summary>
        /// <param name="primaryStat">The total amount of primary stat the Hero has</param>
        /// <param name="critChance">The total amount of critical hit chance the Hero has</param>
        /// <param name="critDamage">The total amount of critical hit damage the Hero has</param>
        /// <param name="APS">The amount of attacks per second the Hero does</param>
        /// <param name="averageDamage">The total amount of average damage the Hero has</param>
        /// <returns>The Hero's Damage</returns>
        private int CalculateHeroDamage(int primaryStat, float critChance, float critDamage, float APS, float averageDamage)
        {
            // SCRAM - http://www.almostgaming.com/diablo3/diablo-3-how-is-damage-calculated/
            float damage = (primaryStat * 0.01f) + 1.0f; // S - Main Stat
            damage *= (critChance * critDamage) + 1.0f; // C - Critical Stats
            damage *= APS; // R - Attacks Per Second
            damage *= averageDamage; // A - Average Damage

            return (int)Math.Round(damage);
        }

        private int CalculatedBuffedHeroDamage()
        {
            float damage = this.Damage;
            float bonusDamage = 0.0f;

            if (this.Class == ClassType.Wizard)
            {
                if (this.ActiveSkills.Contains("Energy Armor") && this.Runes.Contains("Pinpoint Barrier"))
                {
                    damage = this.CalculateHeroDamage(this.PrimaryStat, this.CriticalHitChance + 0.05f, this.CriticalHitDamage, this.AttacksPerSecond, this.GetTotalStat(AffixType.AverageDamage));
                }

                if (this.ActiveSkills.Contains("Magic Weapon"))
                {
                    bonusDamage += 0.10f;

                    if (this.Runes.Contains("Force Weapon"))
                    {
                        bonusDamage += 0.10f;
                    }
                }

                if (this.ActiveSkills.Contains("Familiar") && this.Runes.Contains("Sparkflint"))
                {
                    bonusDamage += 0.10f;
                }

                if (this.PassiveSkills.Contains("Glass Cannon"))
                {
                    bonusDamage += 0.15f;
                }

                if (this.PassiveSkills.Contains("Unwavering Will"))
                {
                    bonusDamage += 0.10f;
                }
            }

            damage *= (1.0f + bonusDamage);

            return (int)Math.Round(damage);
        }

        private int CalculatedEffectiveHeroDamage()
        {
            float damage = this.BuffedDamage;
            float bonusSkillDamage = 0.0f;
            float bonusSpellTypeDamage = 0.0f;
            string bonusedSkill;

            if (this.Class == ClassType.Wizard)
            {
                foreach (string skill in ActiveSkills)
                {
                    if (SkillToAffixMap.ContainsKey(skill))
                    {
                        float tempBonus = this.GetTotalStat(SkillToAffixMap[skill]);
                        
                        if (tempBonus > bonusSkillDamage)
                        {
                            bonusSkillDamage = tempBonus;
                            bonusedSkill = skill;
                        }
                    }
                }
            }

            damage *= (1.0f + bonusSkillDamage);
            damage *= (1.0f + bonusSpellTypeDamage);

            return (int)Math.Round(damage);
        }
    }
}
