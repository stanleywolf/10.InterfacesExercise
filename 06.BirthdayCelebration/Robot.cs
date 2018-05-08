using System;
using System.Collections.Generic;
using System.Text;

public class Robot:IIdentable
{
    public string Name { get; set; }
    public string ID { get; set; }

    public Robot(string name, string id)
    {
        this.Name = name;
        this.ID = id;
    }
}