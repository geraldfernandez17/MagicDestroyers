using System;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        public Hammer()
        {

        }

        public Hammer(int damage)
        {
            base.Damage = damage;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
