using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Car : IManageHP
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
        public override string ToString()
        {
            return $"This is a {this.Make} {this.Model} and it has {this.HorsePower} bhp.";
        }

        public void IncreaseHP(int increase)
        {
            this.HorsePower += increase;
        }

        public void DecreaseHP(int decrease)
        {
            this.HorsePower -= decrease;
        }
    }
}
