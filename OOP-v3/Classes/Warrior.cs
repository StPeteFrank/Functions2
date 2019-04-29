using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public abstract class Warrior : IAttacker
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string Rank { get; set; }

        public IWeapon Weapon { get; set; }

        public Warrior(IWeapon weapon)    //Constructor for Warrior Abstract Parent.
        {
            this.Weapon = weapon;
        }

        public void Attack()
        {
            this.Weapon.DoDamage();
        }
    }
}
