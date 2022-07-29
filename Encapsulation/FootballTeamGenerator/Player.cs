using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
   public class Player
    {
        private string name;
      
        public Player(string name, Stats stat)
        {
            Name = name;
            Stats = stat;
        }
        public Stats Stats
        {
            get; private set;
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

    }
}
