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

        public void IncreaseHP(int increase)      //Methods that accept parameteres:
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


        public ICustomParts CustomParts { get; set; }  // Dependent on CustomParts

        public CarPrototype(ICustomParts customParts)  //Constructor
        {
            this.CustomParts = customParts;
        }
        public void BuildCar()
        {
            this.CustomParts.DecreaseHP(int decrease);
            this.CustomParts.DecreaseValue();
            this.CustomParts.IncreaseHP();
            this.CustomParts.IncreaseValue();
        }
    }
}
