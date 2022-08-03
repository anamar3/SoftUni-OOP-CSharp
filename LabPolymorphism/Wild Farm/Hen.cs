using System;
using System.Collections.Generic;
using System.Text;


    public class Hen: Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight,wingSize)
        {
          
        }

        public override void Eat(IFood food)
        {
            Weight += food.Quantity * 0.35;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }

