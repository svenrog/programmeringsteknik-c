using System;
using System.Collections.Generic;


namespace RecipeScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Recipe>();
            try
            {
                try
                {
                    var recipe = Scraper.GetRecipe("https://www.koket.se/smorstekt-torskrygg-med-pestoslungad-blomkal-och-sparris");
                    list.Add(recipe);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
                try
                {

                    var recipe = Scraper.GetRecipe("https://www.koket.se/vegoburgare-med-tryffelmajonnas");
                    list.Add(recipe); 
       
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
                try
                {
                    var recipe = Scraper.GetRecipe("https://www.koket.se/smakrik-o-lrisotto-med-vitlo-ksrostad-tomat-citronsparris-och-het-chorizo");
                    list.Add(recipe);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
                try
                {
                    var recipe = Scraper.GetRecipe("https://www.koket.se/smorbakad-spetskal-med-krispig-kyckling-och-graddskum");
                    list.Add(recipe);
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            try
            {
                foreach (var recipe in list)
                {
                    Console.WriteLine($"Recept: {recipe.Name}");
                    Console.WriteLine("-------");
                    Console.WriteLine(recipe.Description.Trim());
                    Console.WriteLine("-------");
                    Console.WriteLine("Ingredienser:");
                    
                    foreach (var ingredient in recipe.Ingredient)
                    {
                        if (ingredient.Amount == 0)
                            Console.WriteLine(ingredient.Name);
                        else
                            Console.WriteLine($"{ingredient.Amount} {ingredient.Unit} {ingredient.Name}");
                    }
                    Console.WriteLine("-------");
                    Console.WriteLine("Steg:");
                    var stepCount = 1;
                    foreach (var step in recipe.Step)
                    {
                        Console.WriteLine($"{stepCount}: {step.Tx}");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }
    }
    class Recipe
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredient { get; set; }
        public List<Step> Step { get; set; }
    }
    class Ingredient
    {
        public double Amount { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
    }
    class Step
    {
        public string T1 { get; set; }
        public string Tx { get; set; }
    }
}
