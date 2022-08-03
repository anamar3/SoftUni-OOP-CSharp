using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Animal
    {
        public Animal(string name, string FF)
        {
            Name = name;
            favouriteFood = FF;
        }
        public string Name { get; set; }
        public string favouriteFood { get; set; }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {favouriteFood}";
        }
    }
}
