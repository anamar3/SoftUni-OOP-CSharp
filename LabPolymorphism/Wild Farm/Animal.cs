using System;
using System.Collections.Generic;
using System.Text;


    public abstract class Animal : IAnimal
    {
        public Animal(string name,double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract string ProduceSound();

        public abstract void Eat(IFood food);

       }
