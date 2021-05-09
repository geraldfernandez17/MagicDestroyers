using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private ClothRobe bodyArmor;
        private Staff weapon;


        public Mage()
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
                if (value.Equals("Spellcasters"))
                    faction = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Faction must be Spellcasters for this Character.");
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

        public ClothRobe BodyArmor
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

        public Staff Weapon
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

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
