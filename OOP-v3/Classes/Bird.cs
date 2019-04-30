
using OOP_v3.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Bird : ICanFly
    {
        public string Color { get; set; }
        public int WingSpan { get; set; }
        public int FlySpeed { get; set; }
        public int CurrentFlyingSpeed { get; set; }

        public void FlapWings(int accel)
        {
            this.CurrentFlyingSpeed += this.FlySpeed;
        }

        public void Glide(int deccel)
        {
            this.CurrentFlyingSpeed -= this.FlySpeed;
        }
    }
}
