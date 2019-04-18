using OOP_v3.Classes;
using System;

namespace OOP_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new AddressBookBuilder();
            address.ActualNumber = 1830;
            address.StreetName = "Meridain Ave";
            address.LocationName = "South Beach Apt";
            Console.WriteLine(address);
            //
            var oldBoat = new Boat("Trirton", "Outboard Engine type");
            oldBoat.Buy("Frank");
            Console.WriteLine(oldBoat);
            //
            var horse = new Animal {Name = "Mr. Ed", FavoriteFood = "Grass",Greeting = "Hello Wilbur"}; //No constructor in class so we set out here.
            horse.Speak();
            horse.Eat();
            //
            var horse2 = new Horse { Name = "Clippity Clop" };
            horse2.Speak();
            horse2.Eat();
            //


            Console.ReadLine();
        }
    }
}
