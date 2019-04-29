﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_v3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public string FavoriteFood { get; set; }

        public void Speak()
        {
            Console.WriteLine($"{this.Greeting}. My name is {this.Name}.");
        }
        public void Eat()
        {
            Console.WriteLine($"My favorite food is {FavoriteFood}.");
        }

    }
}
