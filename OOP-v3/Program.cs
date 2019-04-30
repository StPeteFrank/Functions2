using OOP_v3.Classes;
using System;
using System.Collections.Generic;

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
            /*var horse = new Animal {Name = "Mr. Ed", FavoriteFood = "Grass",Greeting = "Hello Wilbur"}; //No constructor in class so we set out here.
            horse.Speak();
            horse.Eat();*/
            //
            var horse2 = new Horse { Name = "Clippity Clop" };
            horse2.Speak();
            horse2.Eat();
            horse2.ShoeMyHorse();
            //
            var Betsy = new Cow {Name = "Betsy" };
            Betsy.Speak();
            Betsy.Eat();
            Betsy.GiveMilk();
            //
            var lancelot = new Knight();
            var legolas = new Archer();
            var merlin = new Wizard();        
            //
            var army = new List<Warrior>();
            army.Add(lancelot);
            army.Add(legolas);
            army.Add(merlin);

            army.ForEach(fighter => fighter.Attack());
            //
            var pegasus1 = new Pegasus(40, 30);
            pegasus1.IncreaseSpeed(20);
            pegasus1.DecreaseSpeed(10);
            pegasus1.FlapWings(10);
            pegasus1.Glide(5);
            Console.WriteLine(pegasus1);

            Console.ReadLine();
        }
    }
}
