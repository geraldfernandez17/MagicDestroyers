using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        public Axe()
        {

        }

        public Axe(int damage)
        {
            base.Damage = damage;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
