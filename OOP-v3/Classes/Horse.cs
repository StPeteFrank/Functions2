using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3.Classes
{
    public class Horse : Animal
    {
        public bool DoesHaveRider { get; set; }
        public int CountOfHorseShoes { get; set; }

        public Horse()
        {
            this.Greeting = "Neigh";
            this.FavoriteFood = "Carrots";
        }

        public int ShoeMyHorse()
        {
            this.CountOfHorseShoes = 4;
            return this.CountOfHorseShoes;
        }
    }
}
