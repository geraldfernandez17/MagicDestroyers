using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;
        private Hammer weapon;

        public Knight()
        {

        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0)
                    abilityPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points must be positive value.");
            }
        }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0)
                    healthPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Health Points must be positive value.");
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 0)
                    level = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Level must be positive value.");
            }
        }

        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value.Equals("Melee"))
                    faction = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Faction must be Melee for this Character.");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Chainlink BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }

        public Hammer Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }

    }
}
