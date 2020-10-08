using System;
using System.Collections.Generic;
using System.Text;
​
namespace Session05Animals
{
    public abstract class Animal
    {
        public int AgeInYears;
        public Animal(int ageInYears) => AgeInYears = ageInYears;
        // Abstract medot
        public abstract void EatFood();
        // Konkret metod
        public void Breed()
        {
            // This implementation does nothing
        }
    }
}