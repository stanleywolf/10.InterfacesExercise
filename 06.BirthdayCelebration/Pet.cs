using System;
using System.Collections.Generic;
using System.Text;


public class Pet : IIdentable,IBirthdable
{
    public string Name { get; set; }
  
    public string Birthday { get; set; }

    public Pet(string name,  string birthday)
    {
        this.Name = name;
        
        this.Birthday = birthday;
    }

}