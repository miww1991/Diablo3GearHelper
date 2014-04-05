using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    /// <summary>
    /// The various Classes in Diablo 3
    /// </summary>
    public enum ClassType
    {
        Barbarian,
        Crusader,
        DemonHunter,
        Monk,
        WitchDoctor,
        Wizard,
        InvalidClassType,

        ClassCount
    }

    /// <summary>
    /// The various Genders in Diablo 3
    /// </summary>
    public enum HeroGender
    {
        Male,
        Female,
        InvalidGenderType,

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

        /// <summary>
        /// The Hero's Class
        /// </summary>
        public ClassType Class { get; private set; }

        /// <summary>
        /// A string representing the Hero's Class
        /// </summary>
        public string ClassString
        {
            get { return _classStrings[(int) this.Class]; }
        }

        /// <summary>
        /// The gender of the Hero
        /// </summary>
        public HeroGender Gender { get; private set; }

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
        /// The last time this Hero was updated
        /// </summary>
        public DateTime LastUpdated { get; private set; }

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
        /// The runes for the hero's skills. These must match up with the Skills indexes.
        /// Note: This will later be updated to be something other than strings
        /// </summary>
        public string[] Runes { get; set; }

        /// <summary>
        /// The skills of the hero
        /// Note: This will later be updated to be something other than strings
        /// </summary>
        public string[] Skills { get; set; }

        /// <summary>
        /// Constructs a Hero Object
        /// </summary>
        public Hero(string name, int id, int level, bool isHardcore, int paragonLevel, HeroGender gender, bool isDead, ClassType charClass, DateTime lastUpdated)
        {
            this.Name = name;
            this.Id = id;
            this.Level = level;
            this.IsHardcore = isHardcore;
            this.ParagonLevel = paragonLevel;
            this.Gender = gender;
            this.IsDead = isDead;
            this.Class = charClass;
            this.LastUpdated = lastUpdated;
            this.Skills = new string[6];
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
    }
}
