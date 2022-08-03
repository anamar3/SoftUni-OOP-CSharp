using System;
using System.Collections.Generic;
using System.Text;


    public class Tiger:Feline
    {
        public Tiger(string name, double weight,string lR,string breed) : base(name, weight,lR, breed)
        {

        }
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        public override void Eat(IFood food)
        {
            if ( food is Meat)
            {
                Weight += food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

