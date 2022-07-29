using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza()
        {
            Toppings = new List<Topping>();
        }
        public Pizza(string name):this()
        {
            Name = name;
            
         
        }
        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public List<Topping> Toppings
        {
            get ; }
         
        

        public string Name
        {
            get { return name; }
           private set { 
                if(value.Length<1 || value.Length>15 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                    name = value; 
            }
        }

        public void AddTopping(Topping topping)
        {
            if(Toppings.Count >= 10 || Toppings.Count<0)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            Toppings.Add(topping);

        }
    }
}
