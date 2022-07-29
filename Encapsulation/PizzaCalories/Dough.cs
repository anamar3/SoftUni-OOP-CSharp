using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
   public class Dough
    {
        private const double White = 1.5;
        private const double Wholegrain = 1.0;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;

        private string flourType;
        private string bakingTech;
        private double weight;
        public Dough()
        {

        }
        public Dough(string fourtype,string bakingtech,double weight)
        {
            FlourType = fourtype;
            BakingTech = bakingtech;
            Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            private set {
                if(value <1 || value >200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public string BakingTech
        {
            get { return bakingTech; }
            private set { 
                if(value.ToLower()!="crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTech = value;
            }
        }

        public string FlourType
        {
            get { return flourType; }
           private set { 
                if(value.ToLower() != "white" &&  value.ToLower()!= "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value; 
            }
        }

        public double CalculateCalories()
        {
            double modifierFT = 0;
            double modifierBT = 0;
            if (FlourType == "White")
            {
                modifierFT = White;
            }
            else if (FlourType.ToLower() == "wholegrain")
                modifierFT = Wholegrain;
            if (BakingTech.ToLower() == "crispy")
                modifierBT = Crispy;
            else if (BakingTech.ToLower() == "chewy")
                modifierBT = Chewy;
            else if (BakingTech.ToLower() == "homemade")
                modifierBT = Homemade;

            return (2 * Weight) * modifierBT * modifierFT;
        }

    }
}
