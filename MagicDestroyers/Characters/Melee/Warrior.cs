using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private static int index_char = 1;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const int DEFAULT_ABILITYPOINTS = 110;

        private const string DEFAULT_NAME = "Warrior";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly Chainlink DEFAULT_BODYARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private Chainlink bodyArmor;
        private Axe weapon;

        public Warrior()
            : this(DEFAULT_NAME + " " + index_char.ToString(), DEFAULT_LEVEL)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
            index_char++;
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
