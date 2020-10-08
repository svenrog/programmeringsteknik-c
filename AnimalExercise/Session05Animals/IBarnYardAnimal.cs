using System;
using System.Collections.Generic;
using System.Text;
​
namespace Session05Animals
{
    public interface IBarnyardAnimal
    {
        string FeedingArea { get; set; }
        string RestingArea { get; }
        
    }
}
