using System;

namespace MagicDestroyers.Equipment.Armors
{
    public class Armor : Equipment
    {
        protected int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value >= 1)
                    this.armorPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points must be greater or equal to 1.");
            }
        }

        public Armor()
        {

        }
    }
}
