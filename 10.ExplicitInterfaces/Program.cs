using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var persons = new List<Citizen>();
        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            var tokens = command.Split();
            var name = tokens[0];
            var country = tokens[1];
            var age = int.Parse(tokens[2]);
            var person = new Citizen(name,country,age);
            persons.Add(person);
        }
        foreach (var person in persons)
        {
            Console.WriteLine(person.GetName());
            Console.WriteLine(((IResident)person).GetName());
        }
    }
}