using System;
using System.Collections.Generic;


    public class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<IAnimal> animals = new List<IAnimal>();

            while((input =Console.ReadLine())!= "End")
            {
             

                try
                {
                    string[] foodInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string[] splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string type = splitted[0];
                    Animal animal = null;
                    if (type == "Cat")
                        animal = new Cat(splitted[1], double.Parse(splitted[2]), splitted[3], splitted[4]);
                    else if (type == "Dog")
                        animal = new Dog(splitted[1], double.Parse(splitted[2]), splitted[3]);
                    else if (type == "Hen")
                        animal = new Hen(splitted[1], double.Parse(splitted[2]), double.Parse(splitted[3]));
                    else if (type == "Mouse")
                        animal = new Mouse(splitted[1], double.Parse(splitted[2]), splitted[3]);
                    else if (type == "Owl")
                        animal = new Owl(splitted[1], double.Parse(splitted[2]), double.Parse(splitted[3]));
                    else if (type == "Tiger")
                        animal = new Tiger(splitted[1], double.Parse(splitted[2]), splitted[3], splitted[4]);



                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);

                    string foodType = foodInfo[0];
                    int qty = int.Parse(foodInfo[1]);

                    IFood food = null;

                    if (foodType == "Vegetable")
                        food = new Vegetable(qty);
                    else if (foodType == "Fruit")
                        food = new Fruit(qty);
                    else if (foodType == "Meat")
                        food = new Meat(qty);
                    else if (foodType == "Seeds")
                        food = new Seeds(qty);

                    animal.Eat(food);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message) ;
                }

            }

            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

