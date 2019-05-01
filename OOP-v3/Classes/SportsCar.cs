using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class SportsCar : CarPrototype
    {
        public SportsCar() : base(new RacingPackage())
        {

        }
        public override string ToString()    //Use an overide ToString for testing output.
        {
            return $"This is a {this.Make} {this.Model} and it has {this.HorsePower} bhp. This {this.Model} is currently worth ${this.CarValue}.";
        }

        //SHOULD THIS TOSTRING OUTPUT CRETOR BE IN CARPROTOTYPE PARENT CLASS INSTEAD??
    }
}
