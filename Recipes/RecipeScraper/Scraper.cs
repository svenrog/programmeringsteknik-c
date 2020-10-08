using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RecipeScraper
{
    class Scraper
    {
        private const string _recipeElementIt = "__NEXT_DATA__";
        private const string _recipeJsonPath = "props.pageProps.structuredData[?(@['\x40type']=='Recipe')]";
        public static Recipe GetRecipe(string url)
        {
            var webRequest = new HtmlWeb();
            var htmlDocument = webRequest.Load(url);
            var recipeData = GetRecipeData(htmlDocument);
            return CreateRecipe(recipeData);
        }

        private static JObject GetRecipeData(HtmlDocument htmlDocument)
        {
            var htmlElement = htmlDocument.GetElementbyId(_recipeElementIt).InnerHtml;
            var structureData = JsonConvert.DeserializeObject<JObject>(htmlElement);
            return structureData.SelectToken(_recipeJsonPath) as JObject;
        }
        private static Recipe CreateRecipe(JObject recipeData)
        {
            var recipe = new Recipe();
            recipe.Name = recipeData["name"].ToObject<string>();
            recipe.Description = recipeData["description"].ToObject<string>();
            recipe.Image = recipeData["image"].ToObject<string>();
            recipe.Ingredient = new List<Ingredient>();
            foreach (var ingredient in recipeData["recipeIngredient"] as JArray)
            {
                var ingredientData = ((string)ingredient).Split(' ');
                var amountData = ingredientData[0];

                Ingredient ingredientToAdd;
                if (double.TryParse(amountData, out var amount))
                {
                    var name = ingredientData.Skip(2);
                    ingredientToAdd = new Ingredient
                    {
                        Amount = amount,
                        Unit = ingredientData[1],
                        Name = string.Join(" ", name)
                    };
                }
                else
                {
                    ingredientToAdd = new Ingredient { Name = (string)ingredient };
                }
                recipe.Ingredient.Add(ingredientToAdd);
            }
            recipe.Step = new List<Step>();

            foreach (var instruction in recipeData["recipeInstructions"] as JArray)
            {
                var stripHtml = new Regex("<[^>]*(>|$)");
                var instructionHtml = (string)instruction["text"];
                var instructionText = stripHtml.Replace(instructionHtml, string.Empty);
                var stepToAdd = new Step
                {
                    Tx = instructionText.Replace("\n", " ")
                };
                recipe.Step.Add(stepToAdd);
            }
            return recipe;
        }
    }
}
