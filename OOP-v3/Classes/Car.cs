using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public Car(string make, string model, int horsePower)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
        }
    }
}
