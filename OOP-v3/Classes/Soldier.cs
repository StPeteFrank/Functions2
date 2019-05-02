using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public abstract class Soldier : IAttacker
    {
        public string Name { get; set; }

        public IWeapon Weapon { get; set; }

        public Soldier(IWeapon Weapon)
        {
            this.Weapon = Weapon;
        }
        public void Attack()
        {
            this.Weapon.DoDamage();
        }
    }
}
