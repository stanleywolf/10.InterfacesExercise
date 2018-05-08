using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

public class Ferrari:IFerrari
{
    public string Model { get; set; }
    public string Driver { get; set; }

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
    }
    public string Brakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.Driver}");
        return sb.ToString();
    }
}