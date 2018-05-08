using System;
using System.Collections.Generic;
using System.Text;

public class AddRemoveColection:AddCollection, IRemove
{
    public AddRemoveColection() : base() { }

    public virtual string Remove()
    {
        string element = this.List[this.List.Count - 1];
        this.List.RemoveAt(this.List.Count - 1);
        return element;
    }

    public override int Add(string element)
    {
        this.List.Insert(0,element);
        return 0;
    }
}