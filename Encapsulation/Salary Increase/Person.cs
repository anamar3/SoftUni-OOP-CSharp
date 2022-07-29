using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo

{
    public class Person
    {
        public Person(string firstname,string secondname, int age,decimal salary)
        {
            this.FirstName =firstname;
            this.LastName = secondname;
            this.Age = age;
            Salary = salary;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get;private set; }
        public decimal Salary { get; private set; }
      
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2;
            }

                this.Salary += this.Salary + this.Salary * percentage/100;
         
        }

    }
}
