using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{

    //Make a showroom of cars that have sportcars, trucks, and sedans
    //sportsCars increase hp and increase value
    //trucks increase hp and decrease value
    //sedans decrease hp and decrease value

    //Store showroom cars in a data strcuture that allows for reuse in creating objects.



    public abstract class CarPrototype : ICarBuilder //Inherit CarBuilder
    {
        public string Make { get; set; }   //Set the properties.
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int CarValue { get; set; }

        public ICustomParts CustomParts { get; set; }  // Dependent on CustomParts

        public CarPrototype(string make, string model, int horsePower, int value, ICustomParts customParts) //Constructor
        {
            this.CustomParts = customParts;
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.CarValue = value;


        }
        public void BuildCar()
        {
            this.CustomParts.DecreaseHP(50);
            this.CustomParts.DecreaseValue(32);
            this.CustomParts.IncreaseHP(12);
            this.CustomParts.IncreaseValue(-12);
        }
    }
}
