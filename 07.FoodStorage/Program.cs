using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<IBuyer> peoples = new List<IBuyer>();

        var nums = int.Parse(Console.ReadLine());

        for (int i = 0; i < nums; i++)
        {
            var tokens = Console.ReadLine().Split();
            if (tokens.Length == 4)
            {
                peoples.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
            }
            else if (tokens.Length == 3)
            {
                peoples.Add(new Rabel(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }
        }
        string command;
        while ((command=Console.ReadLine()) != "End")
        {
            var bayer = peoples.SingleOrDefault(b => b.Name == command);
            if (bayer != null)
            {
                bayer.BayFood();
            }
        }
        Console.WriteLine(peoples.Sum(x => x.Food));
    }
}