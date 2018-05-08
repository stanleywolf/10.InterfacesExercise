using System;
using System.Collections.Generic;
using System.Text;

public abstract class Collections:IAdd
{
    private List<string> list;
    protected IList<string> List { get { return this.list; } }
    public Collections()
    {
        this.list = new List<string>();
    }

    public abstract int Add(string element);
    
}