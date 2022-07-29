using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double Meat = 1.2;
private const double Veggies = 0.8;
private const double Cheese = 1.1;
private const double Sauce =0.9;

        private string type;
        private double weight;

        public Topping(string type,double weight)
        {
            Type = type;
            Weight = weight;
        }
        public double Weight
        {
            get { return weight; }
            private set { 
                if(value<1 || value>50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public string Type
        {
            get { return type; }
            private set { 
                if(value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() !="cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value; 
            }
        }

        public double CalculateCalories()
        {
            double modifier = 0;
            if (Type.ToLower() == "meat")
                modifier = Meat;
            else if (Type.ToLower() == "veggies")
                modifier = Veggies;
            else if (Type.ToLower() == "sauce")
                modifier = Sauce;
            else if (Type.ToLower() == "cheese")
                modifier = Cheese;

            return 2 * modifier * Weight;

        }

    }
}
