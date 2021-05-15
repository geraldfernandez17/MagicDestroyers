using MagicDestroyers.Enums;
using MagicDestroyers.Interfaces;
using System;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const string DEFAULT_NAME = "Assassin";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        protected int healthPoints;
        protected int level;
        protected Faction faction;
        private string name;

        public Character()
            : this(DEFAULT_HEALTHPOINTS, DEFAULT_LEVEL)
        {

        }

        public Character(int healthPoints, int level)
            : this(healthPoints, level, DEFAULT_NAME)
        {

        }

        public Character(int healthPoints, int level, string name)
        {
            this.healthPoints = healthPoints;
            this.level = level;
            this.faction = DEFAULT_FACTION;
            this.name = name;
        }

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

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
    }
}
