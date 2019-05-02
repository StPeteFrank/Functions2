using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class GrenadierSoldier : Soldier
    {
        public GrenadierSoldier() : base(new GrenadeLauncher())
        {

        }
    }
}
