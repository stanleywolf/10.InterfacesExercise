using System;
using System.Collections.Generic;
using System.Text;

public class Rabel :IIdentable,IBuyer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
    public int Food { get; set; }

    public Rabel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }
    public void BayFood()
    {
        this.Food += 5;
    }

}
