using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Knight : Warrior
    {
        public Knight() : base(new Sword())  //Injecting the dependency of Sword form IWeapon.
        {

        }
    }
}
