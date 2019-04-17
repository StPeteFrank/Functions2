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

            Console.ReadLine();
        }
    }
}
