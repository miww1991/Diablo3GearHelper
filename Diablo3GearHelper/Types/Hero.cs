using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
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

    public enum HeroGender
    {
        Male,
        Female,
        InvalidGenderType,

        GenderCount
    }

    public class Hero
    {
        private readonly string[] _classStrings =
        {
            "Barbarian", "Crusader", "Demon Hunter", "Monk", "Witch Doctor",
            "Wizard", "Invalid Class"
        };

        /// <summary>
        /// The Hero's Class
        /// </summary>
        public ClassType Class { get; private set; }

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
        }

        public override string ToString()
        {
            return this.Name + " - Level " + this.Level + " " + this.ClassString;
        }
    }
}
