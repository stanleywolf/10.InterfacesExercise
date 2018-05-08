using System;


class Program
{
    static void Main(string[] args)
    {
        AddCollection ac = new AddCollection();
        AddRemoveColection arc = new AddRemoveColection();
        MyList myList = new MyList();

        var input = Console.ReadLine().Split();

        foreach (var item in input)
        {
            Console.Write($"{ac.Add(item)} ");
        }
        Console.WriteLine();
        foreach (var item in input)
        {
            Console.Write($"{arc.Add(item)} ");
        }
        Console.WriteLine();
        foreach (var item in input)
        {
            Console.Write($"{myList.Add(item)} ");
        }
        Console.WriteLine();

        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{arc.Remove()} ");
        }
        Console.WriteLine();
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{myList.Remove()} ");
        }
        Console.WriteLine();
    }
}