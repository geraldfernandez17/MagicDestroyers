using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private static int index_char = 1;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const int DEFAULT_MANAPOINTS = 125;

        private const string DEFAULT_NAME = "Necromancer";
        private const Faction DEFAULT_FACTION = Faction.Spellcasters;

        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public Necromancer()
            : this(DEFAULT_NAME + " " + index_char.ToString(), DEFAULT_LEVEL)
        {

        }

        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANAPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
            index_char++;
        }

        public LightLeatherVest BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        public Sword Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}
