﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer
    {
        private int damage;

        public Hammer()
        {

        }

        public Hammer(int damage)
        {
            this.Damage = damage;
        }

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

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
