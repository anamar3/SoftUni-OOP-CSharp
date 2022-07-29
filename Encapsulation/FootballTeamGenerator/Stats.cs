using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
   public class Stats
    {
        private const int StatMinValue = 0;
        private const int StatMaxValue = 100;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public double GetOverallStat() => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
        public Stats(int endu,int sprint,int dribb,int pass,int shoot)
        {
            Endurance = endu;
            Sprint = sprint;
            Dribble = dribb;
            Passing = pass;
            Shooting = shoot;
        }
        public int Shooting
        {
            get { return shooting; }
            private set {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.StatsMessage, nameof(this.Shooting)));
                }
                shooting = value; 
            }
        }


        public int Passing
        {
            get { return passing; }
            private set {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.StatsMessage, nameof(this.Passing)));
                }
                passing = value; 
            }
        }

        public int Endurance
        {
            get { return endurance; }
           private set {
                if(value<StatMinValue || value>StatMaxValue)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.StatsMessage,nameof(this.Endurance)));
                }
                endurance = value;
            }
        }
   

        public int Sprint
        {
            get { return sprint; }
            private set {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.StatsMessage, nameof(this.Sprint)));
                }
                sprint = value; 
            }
        }
       

        public int Dribble
        {
            get { return dribble; }
            private set {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.StatsMessage, nameof(this.Dribble)));
                }
                dribble = value;
            }
        }



    }
}
