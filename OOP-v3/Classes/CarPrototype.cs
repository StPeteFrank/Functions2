using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{

    //Make a showroom of cars that have sportcars, trucks, and sedans
    //sportcars increase hp and increase value
    //trucks increase hp and decrease value
    //sedans decrease hp and decrease value

    //Store showroom cars in a data strcuture that allows for reuse in creating objects.



    public abstract class CarPrototype   //Make it abstract first.
    {
        public string Make { get; set; }   //Set the properties.
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int CarValue { get; set; }
    }
}
