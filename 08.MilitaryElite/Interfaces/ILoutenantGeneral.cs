using System;
using System.Collections.Generic;
using System.Text;

public interface ILoutenantGeneral :IPrivate
{
    IReadOnlyCollection<IPrivate> Privates { get; }
   
}