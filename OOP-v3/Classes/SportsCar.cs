using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class SportsCar : CarPrototype
    {
        public SportsCar(string make, string model, int horsePower, int value) : base(make, model, horsePower, value, new RacingPackage())
        {

        }

        public void IncreaseHpToSportCarLevels()
        {
            this.CustomParts.IncreaseHP(1000);
        }

      

        public override string ToString()    //Use an overide ToString for testing output.
        {
            return $"This is a {this.Make} {this.Model} and it has {this.HorsePower} bhp. This {this.Model} is currently worth ${this.CarValue}.";
        }
       
        public void IncreaseHP(int increase)      
        {                                       
            this.HorsePower += increase;
        }
        public void DecreaseHP(int decrease)
        {
            this.HorsePower -= decrease;
        }

        public void IncreaseValue(int increase)
        {
            this.CarValue += increase;
        }

        public void DecreaseValue(int decrease)
        {
            this.CarValue -= decrease;
        }

    }
}
