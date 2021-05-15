using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe : Light
    {
        public ClothRobe()
        {

        }

        public ClothRobe(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
