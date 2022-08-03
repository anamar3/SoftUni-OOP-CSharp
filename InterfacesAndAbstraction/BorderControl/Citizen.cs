using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen: IID
    {
        private string name;

        private int age;
        public Citizen(string name,int age,string iD,string birthdate)
        {
            Name = name;
            Age = age;
            ID = iD;
            Birthdate = birthdate;
        }
        public string Birthdate { get; set; }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ID { get ; set; }
    }
}
