using MagicDestroyers.Enums;
using System;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        protected int healthPoints;
        protected int level;
        protected Faction faction;
        private string name;

        public virtual int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    this.healthPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Character Health Points must be positive value and the value must be between 0 untill 100.");
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                    this.level = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Level must be positive value.");
            }
        }

        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Character()
        {

        }
    }
}
