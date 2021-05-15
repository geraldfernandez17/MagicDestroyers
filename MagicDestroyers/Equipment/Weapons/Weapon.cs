using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon : Equipment
    {
        protected int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 1)
                    this.damage = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage must be greater or equal to 1.");
            }
        }

        public Weapon()
        {

        }
    }
}
