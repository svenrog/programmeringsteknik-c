using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RecipeScraper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace RecipeScraper
{
    class Scraper
    {
        private const string _recipeElementId = "___NEXT_DATA___";
        private const string _recipeJsonPath = "props.pageProps.structuredData[?(@['\x40type']=='Recipe')]";

        private static readonly JsonSerializer _serializer;


        // Ignorerar att filen är skriven i camel när den sätts till property
        static Scraper()
        {
            _serializer = new JsonSerializer
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        public static Recipe GetRecipe(string url)
        {
            var webRequest = new HtmlWeb();
            var htmlDocument = webRequest.Load(url);

            var recipeData = GetRecipeData(htmlDocument);

            return CreateRecipe(recipeData);
            // var request = (HttpWebRequest)WebRequest.Create(@"https://www.koket.se/vegoburgare-med-tryffelmajonnas");


            //using (var response = request.GetResponse())
            //{
            //    var recipe = new Recipe();
            //    var htmlDocument = new HtmlDocument();

            //    using (var content = response.GetResponseStream())
            //    {
            //        using (var buffer = new MemoryStream())
            //        {
            //            content.CopyTo(buffer);
            //            buffer.Seek(0, SeekOrigin.Begin);
            //            htmlDocument.Load(buffer);


            //            var structuredData = JsonConvert.DeserializeObject<JObject>(htmlDocument.GetElementbyId("__NEXT_DATA__").InnerHtml)
            //                                            .SelectToken("props.pageProps.structuredData[?(@['\x40type']=='Recipe')]") as JObject;
            //        }
            //    }
            //}

        }

        private static JObject GetRecipeData(HtmlDocument htmlDocument)
        {
            var htmlElement = htmlDocument.GetElementbyId(_recipeJsonPath).InnerHtml;
            var structuredData = JsonConvert.DeserializeObject<JObject>(htmlElement);

            return structuredData.SelectToken(_recipeJsonPath) as JObject;

        }

        private static Recipe CreateRecipe(JObject recipeData)
        {
            var dto = recipeData.ToObject<RecipeDto>(_serializer);

            return new Recipe()
            {
                Name = dto.Name,
                Description = dto.Description,
                Image = dto.Image,
                Ingredients = MapIngredients(dto.RecipeIngredient),
                Steps = MapsSteps(dto.RecipeInstructions)

            };
        
        }

        private static List<Step> MapSteps(List<InstructionDto> instructionData)
        {
            return instructionData.Select(MapStep).ToList();
        }
        private static Step MapStep(InstructionDto instructionData)
        {
            var stripHtml = new Regex("<[^>]*(>|$)");
            var instructionHtml = instructionData.Text;
            var instructionText = stripHtml.Replace(instructionHtml, string.Empty);

            return new Step
            {
                Text = instructionText.Replace("\n", " ")
            };
        }

        private static List<Ingredient> MapIngredients(List<string> ingredientData)
        {
            return ingredientData.Select(MapIngredient).ToList();
        }
        private static Ingredient MapIngredient(string ingredientText)
        {
            var ingredientData = ingredientText.Split(' ');
            var amountData = ingredientData[0];

            if (double.TryParse(amountData, out var amount)
            {

            }
        }

     }
}

