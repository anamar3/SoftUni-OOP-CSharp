using System;
using System.Collections.Generic;
using System.Text;


    public class Cat: Feline
    {
        public Cat(string name, double weight,string livingRegion,string breed) : base(name, weight,livingRegion,breed)
        {

        }
        public override string ProduceSound()
        {
            return "Meow";
        }
        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Meat)
            {
                Weight += 0.30 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
