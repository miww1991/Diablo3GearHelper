using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3GearHelper.Types
{
    public enum HeroGender
    {
        Male,
        Female,
    }

    public class Hero
    {
        /// <summary>
        /// The gender of the Hero
        /// </summary>
        public HeroGender Gender { get; private set; }

        /// <summary>
        /// The ID of the Hero
        /// </summary>
        public int ID { get; private set; }
        
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
        /// Constructs a Hero Object
        /// </summary>
        public Hero(string Name, int ID, int Level, bool isHardcore, HeroGender Gender, DateTime LastUpdated, bool isDead)
        {
            this.Name = Name;
            this.ID = ID;
            this.Level = Level;
            this.IsHardcore = isHardcore;
            this.Gender = Gender;
            this.LastUpdated = LastUpdated;
            this.IsDead = isDead;
        }
    }
}
