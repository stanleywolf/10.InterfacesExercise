using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IIdentable> things = new List<IIdentable>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] inputArgs = command.Split();

            if (inputArgs.Length == 2)
            {
                things.Add(new Robot(inputArgs[0], inputArgs[1]));
            }
            if (inputArgs.Length == 3)
            {
                things.Add(new Citizen(inputArgs[0], inputArgs[2]));
            }
        }
        var idChecker = Console.ReadLine();
        foreach (var thing in things)
        {
            if (thing.ID.EndsWith(idChecker))
            {
                Console.WriteLine(thing.ID);
            }
        }
    }
}