using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public interface IWeapon
    {
        void DoDamage();
    }

    public class Sword : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Swings sword.");
        }
    }

    public class BowAndArrow : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Shoots arrow.");
        }
    }

    public class FireBall : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Firing a ball of fire.");
        }
    }
}
