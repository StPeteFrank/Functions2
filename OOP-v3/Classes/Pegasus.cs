using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Pegasus : ICanGallop, ICanFly
    {
        public int WingSpan { get ; set ; }
        public int FlySpeed { get ; set ; }
        public int CurrentFlyingSpeed { get; set; } 
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
            this.MaxSpeed -= deccel;
        }

        public void FlapWings(int accel)
        {
            this.CurrentFlyingSpeed += accel;
        }

        public void Glide(int deccel)
        {
            this.CurrentFlyingSpeed -= deccel;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel;
        }
    }
}
