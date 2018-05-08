using System;
using System.Collections.Generic;
using System.Text;

public interface IBuyer
{
    void BayFood();
    int Food { get; set; }
    string Name { get; set; }
}