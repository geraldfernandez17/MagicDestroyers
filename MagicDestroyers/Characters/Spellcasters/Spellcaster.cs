using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        protected int manaPoints;
        public int ManaPoints 
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0)
                    this.manaPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Mana Points must be positive value.");
            }
        }

        public Spellcaster()
        {

        }
    }
}
