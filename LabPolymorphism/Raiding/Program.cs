using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> allHeros = new List<BaseHero>();

            while (n != 0)
            {
                string inputName = Console.ReadLine();
                string inputType = Console.ReadLine();
                try
                {
                    BaseHero hero = null;
                    if (inputType == "Paladin")
                        hero = new Paladin(inputName);
                    else if (inputType == "Druid")
                        hero = new Druid(inputName);
                    else if (inputType == "Rogue")
                        hero = new Rogue(inputName);
                    else if (inputType == "Warrior")
                        hero = new Warrior(inputName);
                    else
                    {
                        throw new ArgumentException("Invalid hero!");
                    }

                    hero.CastAbility();
                    allHeros.Add(hero);
                    n--;

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            long strenghtOfAttack = long.Parse(Console.ReadLine());

            if((long)allHeros.Sum(h=>h.Power) >= strenghtOfAttack)
            {
                Console.WriteLine("Victory!");
            }
            else
                Console.WriteLine("Defeat...");
        }
    }
}
