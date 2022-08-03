using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<IBuyer> buyers = new List<IBuyer>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            if (input.Length == 4)
            {
                buyers.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
            }
            else
                buyers.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
        }

        string name;

        while ((name=Console.ReadLine()) != "End")
        {
          IBuyer some= buyers.FirstOrDefault(b => b.Name == name);
            if (some == null)
                continue;
            else
                some.BuyFood();
        }
        Console.WriteLine(buyers.Select(b=>b.Food).Sum());




        //List<IBirthable> all = new List<IBirthable>();

        //string command;

        //while ((command = Console.ReadLine()) != "End")
        //{
        //    var tokens = command.Split();

        //    switch (tokens[0])
        //    {
        //        case "Citizen":
        //            all.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
        //            break;
        //        case "Pet":
        //            all.Add(new Pet(tokens[1], tokens[2]));
        //            break;
        //    }
        //}

        //int year = int.Parse(Console.ReadLine());

        //all.Where(c => c.Birthdate.Year == year)
        //    .Select(c => c.Birthdate)
        //    .ToList()
        //    .ForEach(dt => Console.WriteLine($"{dt:dd/mm/yyyy}"));
    }
}
