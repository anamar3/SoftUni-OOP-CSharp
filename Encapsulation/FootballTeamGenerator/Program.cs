using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Team> teams = new List<Team>();

            string command;

            while ((command = Console.ReadLine())!= "END")
            {
                try
                {
                    string[] splitted = command.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    if (splitted[0] == "Team")
                    {
                        Team team = new Team(splitted[1]);
                        teams.Add(team);
                    }
                    else 
                    {
                        Team team = teams.FirstOrDefault(p => p.Name == splitted[1]);
                        if (team== null)
                        {
                            throw new ArgumentException($"Team {splitted[1]} does not exist.");
                        }
                       else if (splitted[0] == "Add")
                        {
                            Stats stats = new Stats(int.Parse(splitted[3]), int.Parse(splitted[4]), int.Parse(splitted[5]), int.Parse(splitted[6]), int.Parse(splitted[7]));
                            Player player = new Player(splitted[2], stats);


                            team.AddPlayer(player);
                        }

                       else if (splitted[0] == "Remove")
                        {

                            team.RemovePlayer(splitted[2]);
                        }
                    else if(splitted[0] == "Rating")

                        { 
                            int rating = teams.First(t => t.Name == splitted[1]).Rating;
                        
                            Console.WriteLine($"{splitted[1]} - {rating}");
                        }    
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(ErrorMessages.NullOrWhiteSpaceException);
                }

            }

        }
    }
}
