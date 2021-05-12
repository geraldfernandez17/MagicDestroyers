using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink
    {
        private int armorPoints;
        public Chainlink()
        {

        }

        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }

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
    }
}
