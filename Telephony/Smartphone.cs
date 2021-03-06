﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone:ICallable,IBrowsable
{
    public string Calling(string number)
    {
        if (!number.All(char.IsDigit))
        {
            return "Invalid number!";
        }
        return $"Calling... {number}";
    }

    public string Browsing(string url)
    {
        if (url.Any(char.IsDigit))
        {
            return "Invalid URL!";
        }
        return $"Browsing: {url}!";
    }
}