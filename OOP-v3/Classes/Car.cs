using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Car : IManageHP     //Inherit Interfaces for method use and easy object reuse.
    {
        public string Make { get; set; }   //Set the properties.
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int CarValue { get; set; }

        public Car(string make, string model, int horsePower, int carValue)   //Create a constructor for reusability in creating objects.
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            CarValue = carValue;
        }
        public override string ToString()    //Use an overide ToString for testing output.
        {
            return $"This is a {this.Make} {this.Model} and it has {this.HorsePower} bhp. This {this.Model} is currently worth ${this.CarValue}.";
        }

        public void IncreaseHP(int increase)      //Methods that accept parameteres:
        {
            this.HorsePower += increase;
        }

        public void DecreaseHP(int decrease)
        {
            this.HorsePower -= decrease;
        }
    }
}
