using System;

namespace Search.Common.Models
{
    public class RecipeDocument
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Steps { get; set; }
        public string Ingredients { get; set; }
        public double Rating { get; set; }
        public TimeSpan? TimeToCook { get; set; }
    }
}
