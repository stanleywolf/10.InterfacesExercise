using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IBirthdable> things = new List<IBirthdable>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var tokens = command.Split();

            if (tokens[0] == "Pet")
            {
                things.Add(new Pet(tokens[1], tokens[2]));
            }
            else if(tokens[0] == "Citizen")
            {
                things.Add(new Citizen(tokens[1], tokens[4]));
            }
        }
        var year = Console.ReadLine();
        foreach (var thing in things)
        {
            if (thing.Birthday.EndsWith(year))
            {
                Console.WriteLine(thing.Birthday);
            }
        }
    }
}