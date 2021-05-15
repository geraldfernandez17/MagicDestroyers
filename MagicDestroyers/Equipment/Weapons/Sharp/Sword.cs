using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        public Sword()
        {

        }

        public Sword(int damage)
        {
            base.Damage = damage;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
