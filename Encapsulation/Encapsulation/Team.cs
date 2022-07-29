using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
       private List<Person> firstTeam ;
        private List<Person> reverseTeam;

        public Team(string name)
        {
            Name = name;
            firstTeam = new List<Person>();
            reverseTeam = new List<Person>();
        }

        public  string Name { get; set; }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reverseTeam.AsReadOnly(); }
        }



        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
                firstTeam.Add(person);
            else
                reverseTeam.Add(person);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First team has {firstTeam.Count} players.");
           sb.AppendLine($" Reserve team has {reverseTeam.Count} players.");
            return sb.ToString().TrimEnd();
        }
    }
}
