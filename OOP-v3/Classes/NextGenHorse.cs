using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class NextGenHorse : ICanGallop
    {
        public int NumberOfShoes { get; set; }
        public string ManeColor { get; set; }
        public string Breed { get; set; }
        public int MaxSpeed { get; set; }

        public void DecreaseSpeed(int deccel)
        {
            this.MaxSpeed -= deccel;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel;
        }
    }
}
