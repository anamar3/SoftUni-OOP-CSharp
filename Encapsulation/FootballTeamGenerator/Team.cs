using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
       
        private string name;
        private readonly List<Player> players;
       
        public Team()
        {
            players = new List<Player>();
        }
        public Team(string name):this()
        {
            Name = name;
            
        }
        public int Rating
        {
            get
            {
                if (this.players.Any())
                {
                    return (int)Math.Round(this.players.Average(p => p.Stats.GetOverallStat()), 0);
                }

                return 0;
            }
        }


        public string Name
        {
            get { return name; }
            private set { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorMessages.NullOrWhiteSpaceException);
                }
                name = value; 
            }
        }

       public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            Player player = players.FirstOrDefault(p => p.Name == playerName);
            if (player == null)
                throw new ArgumentException(string.Format(ErrorMessages.DoesntExist, playerName, this.Name));
            players.RemoveAll(p=>p.Name==playerName);
        }

    }
}
