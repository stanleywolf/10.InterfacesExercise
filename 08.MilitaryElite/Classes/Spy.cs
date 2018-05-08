using System;
using System.Collections.Generic;
using System.Text;

public class Spy:Soldier,ISpy
{
    public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
    {
        this.Code = codeNumber;
    }

    public int Code { get; private set; }

    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}Code Number: {this.Code}";
    }
}