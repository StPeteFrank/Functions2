using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Horse : Animal
    {
        public bool DoesHaveRider { get; set; }
        public int CountOfHorseShoes { get; set; } = 4;

        public Horse()
        {
            this.Greeting = "Neigh";
            this.FavoriteFood = "Carrots";
        }

        public void ShoeMyHorse()
        {
            Console.WriteLine($"I have {this.CountOfHorseShoes} horseshoes.");
            /*this.CountOfHorseShoes = 4;
            return this.CountOfHorseShoes;*/
        }
    }
}
