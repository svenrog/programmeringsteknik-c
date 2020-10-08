using System;
using System.Collections.Generic;
using System.Text;
​
namespace Session05Animals
{
    public class Cow : Animal
    {
        /// <summary>
        /// Creates an instane of Cow object
        /// </summary>
        /// <param name="ageInYears">The age of the cow in years</param>
        public Cow(int ageInYears) : base(ageInYears)
        {
        }
​
        public override void EatFood()
        {
            // Denna metod saknar implementation, med der är okej för att det finns ingen returtyp
        }
        public void SupplyMilk()
        {
            // supply milk koden
        }
    }
}
