using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IIdentifiable, IBirthable, IName, IBuyer
{
    private int age;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.age = age;
        this.Id = id;
        this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        Food = 0;
    }

    public string Id { get; private set; }

    public DateTime Birthdate { get; private set; }

    public string Name { get; private set; }

    public int Food { get; private set; }

    public void BuyFood()
    {
        Food += 10;
    }
}