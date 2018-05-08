using System;
using System.Collections.Generic;
using System.Text;

public class Citizen :IIdentable, IBuyer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string ID { get; set; }
    public DateTime Birthdate { get; set; }
    public int Food { get; set; }

    public Citizen(string name, int age,string id, string birthday )
    {
        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.Birthdate = DateTime.ParseExact(birthday,"dd/MM/yyyy",null);       
    }
    public void BayFood()
    {
        this.Food += 10;
    }

}