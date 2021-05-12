using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;
        private Axe weapon;

        public Warrior()
            : this("Samurai", 12)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, 7000)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = "Melee";
            this.AbilityPoints = 80;
            this.Weapon = new Axe();
            this.BodyArmor = new Chainlink();
        }

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0)
                    this.abilityPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points must be positive value.");
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0)
                    this.healthPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Health Points must be positive value.");
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

        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value.Equals("Melee"))
                    this.faction = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Faction must be Melee for this Character.");
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

        public Chainlink BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        public Axe Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
