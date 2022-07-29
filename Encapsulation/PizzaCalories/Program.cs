using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            double sumCals = 0;
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split(' ');
                 pizza = new Pizza(pizzaInfo[1]);
               
            
          
            string input = Console.ReadLine();
            while (input != "END")
                {
                    string[] splitted = input.Split(' ');
                    if (splitted[0] == "Dough")
                    {
                        Dough d = new Dough(splitted[1], splitted[2], double.Parse(splitted[3]));
                        sumCals += d.CalculateCalories();
                        pizza.Dough = d;

                    }
                    else if (splitted[0] == "Topping")
                    {
                        Topping topping = new Topping(splitted[1], double.Parse(splitted[2]));
                        pizza.AddTopping(topping);
                        sumCals += topping.CalculateCalories();
                    }

                    input = Console.ReadLine();
                }
         
           
            
          
            Console.WriteLine($"{pizza.Name} - {sumCals:F2} Calories.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
          
        }
           
            
        }
    }

