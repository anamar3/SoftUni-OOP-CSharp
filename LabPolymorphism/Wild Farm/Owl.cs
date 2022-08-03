using System;
using System.Collections.Generic;
using System.Text;


    public class Owl: Bird
    {
        public Owl(string name, double weigth, double WS):base(name,weigth,WS)
        {

        }

        public override void Eat(IFood food)
        {
            if(food is Meat)
            {
                Weight += 0.25 * food.Quantity;
                FoodEaten+= food.Quantity;
            }
            else
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }

