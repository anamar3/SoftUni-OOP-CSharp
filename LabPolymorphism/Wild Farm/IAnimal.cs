using System;
using System.Collections.Generic;
using System.Text;


    public interface IAnimal
    {
        public string Name { get; set; }
        public int FoodEaten { get; set; }
        public double Weight { get; set; }
        public abstract string ProduceSound();
        public void Eat(IFood food);
    }

