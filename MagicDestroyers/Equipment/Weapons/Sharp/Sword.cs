using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword
    {
        private int damage;

        public Sword()
        {

        }

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                    damage = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage must be greater or equal to 1.");
            }
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
