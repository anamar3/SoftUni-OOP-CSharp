using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Robot> robots = new List<Robot>();
            List<Citizen> citizens = new List<Citizen>();
            List<Pet> pets = new List<Pet>();
            List<string> dates = new List<string>();

            while ((input=Console.ReadLine()) !="End")
            {
                string[] splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (splitted.Length == 5)
                {
                    Citizen citizen = new Citizen(splitted[1], int.Parse(splitted[2]), splitted[3],splitted[4]);
                    citizens.Add(citizen);
                    dates.Add(splitted[4]);
                   
                }
                else if(splitted[0] == "Robot")
                {
                    Robot robot = new Robot(splitted[1], splitted[2]);
                    robots.Add(robot);
                    dates.Add(splitted[2]);


                }
                else
                {
                    Pet pet = new Pet(splitted[1],splitted[2]);
                    dates.Add(splitted[2]);

                }
            }
            string year = Console.ReadLine();

           

            foreach (var item in dates.Where(d=>d.EndsWith(year)))
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
