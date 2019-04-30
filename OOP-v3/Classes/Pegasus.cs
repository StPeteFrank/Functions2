using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Pegasus : ICanGallop, ICanFly
    {
        public int WingSpan { get ; set ; }
        public int FlySpeed { get ; set ; }
        public int CurrentFlyingSpeed { get ; set ; }
        public int NumberOfShoes { get ; set ; }
        public int MaxSpeed { get ; set ; }

        public override string ToString()
        {
            return $"The Pegasus has a run speed of {this.MaxSpeed} mph. It also has a fly speed of {this.CurrentFlyingSpeed} mph.";
        }

        public Pegasus(int maxSpeed, int currentFlySpeed)
        {
            MaxSpeed = maxSpeed;
            CurrentFlyingSpeed = currentFlySpeed;
        }

        public void DecreaseSpeed(int deccel)
        {
            this.MaxSpeed -= deccel * 2;
        }

        public void FlapWings()
        {
            this.CurrentFlyingSpeed += this.FlySpeed * 2;
        }

        public void Glide()
        {
            this.CurrentFlyingSpeed -= this.FlySpeed;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel * 2;
        }
    }
}
