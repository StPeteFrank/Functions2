using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public interface ICanGallop
    {
        int NumberOfShoes { get; set; }
        int MaxSpeed { get; set; }
        void IncreaseSpeed(int accel);
        void DecreaseSpeed(int deccel);
    }
}
