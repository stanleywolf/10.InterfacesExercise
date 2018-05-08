using System;
using System.Collections.Generic;
using System.Text;

public class Citizen:IResident,IPerson
{
    public string Name { get; }
    public string Country { get; }
    public int Age { get; }

    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs {this.Name}";
    }

     public string GetName()
     {
         return this.Name;
     }


    public Citizen(string name, string country, int age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }
}