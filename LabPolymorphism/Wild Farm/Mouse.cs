using System;
using System.Collections.Generic;
using System.Text;


   public class Mouse: Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight,livingRegion)
        {
            
        }
        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override void Eat(IFood food)
        {
            if(food is Vegetable || food is Fruit)
            {
                Weight += 0.1 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
