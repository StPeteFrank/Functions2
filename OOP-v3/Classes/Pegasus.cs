using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Pegasus : Horse, ICanFly
    {
        public int WingSpan { get ; set ; }
        public int FlySpeed { get ; set ; }
        public int CurrentFlyingSpeed { get ; set ; }

        public void FlapWings()
        {
            this.CurrentFlyingSpeed += this.FlySpeed * 2;
        }

        public void Glide()
        {
            this.CurrentFlyingSpeed -= this.FlySpeed;
        }
    }
}
