using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        public Staff()
        {

        }

        public Staff(int damage)
        {
            base.Damage = damage;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
