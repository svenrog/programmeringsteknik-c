using System;
using System.Collections.Generic;
using System.Text;
​
namespace Session05Animals
{
    public class Chicken : Animal, IBarnyardAnimal
    {
        private string _feedingArea;
        private string _restingArea;
​
        // Genväg för att kalla på konstruktor i basklass
        public Chicken(int ageInYears) : base(ageInYears) { }
​
        public string FeedingArea
        {
            get => _feedingArea;
            set => _feedingArea = value;
        }
        public string RestingArea => _restingArea;
​
        public override void EatFood()
        {
            // Implementation av metoden
            // Fyller metoden med logik
        }
​
        public void Sleep()
        {
            Console.WriteLine("sleeping");
        }
    }
}