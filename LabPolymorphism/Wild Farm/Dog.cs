using System;
using System.Collections.Generic;
using System.Text;

    public class Dog: Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {

                Weight += 0.4 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    
}