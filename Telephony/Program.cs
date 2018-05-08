using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split();
        var sites = Console.ReadLine().Split();        

        foreach (var number in numbers)
        {
            ICallable nums = new Smartphone();
            Console.WriteLine(nums.Calling(number));
        }
        foreach (var s in sites)
        {
            IBrowsable site = new Smartphone();
            Console.WriteLine(site.Browsing(s));
        }        
    }
}