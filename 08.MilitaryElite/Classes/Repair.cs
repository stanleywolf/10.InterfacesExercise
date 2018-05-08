using System;
using System.Collections.Generic;
using System.Text;

public class Repair:IRepair
{
    public string Part { get; private set; }
    public int Hours { get; private set; }

    public Repair(string partName, int hoursWorked)
    {
        this.Part = partName;
        this.Hours = hoursWorked;
    }

    public override string ToString()
    {
        return $"Part Name: {this.Part} Hours Worked: {this.Hours}";
    }
}