using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Melee : Character
    {
        protected int abilityPoints;

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

        public Melee()
        {

        }
    }
}
