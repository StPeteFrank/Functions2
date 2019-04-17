using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Boat
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Value { get; set; } = 0;
        public bool IsUsed { get; set; }
        public string OwnerName { get; set; }

        public override string ToString()
        {
            return $"{OwnerName} is the owner of an {Brand} and it is a {Type} boat. Is the boat used? {Buy("Frank")}.";
        }

        public Boat(string brand, string type)     // Constructor
        {
           // Console.WriteLine("Creating a new boat.");
            Brand = brand;
            Type = type;
        }
        public Boolean Buy(string owner)  // Method
        {
            IsUsed = true;
            OwnerName = owner;
            return IsUsed;
        }

    }
}
