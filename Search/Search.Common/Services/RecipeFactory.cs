using Search.Common.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Search.Common.Services
{
    public static class RecipeFactory
    {
        public static RecipeDocument CreateFrom(Uri uri)
        {
            var data = RecipeScraper.GetRecipeData(uri);

            return new RecipeDocument
            {
                Id = GenerateGuidFromUrl(uri),
                Name = data.Name,
                Author = data.Author?.Name,
                Description = data.Description,
                Image = data.Image,
                Rating = data.AggregateRating?.RatingValue ?? 0,
                Ingredients = string.Join("\n", data.RecipeIngredient),
                Steps = string.Join("\n", data.RecipeInstructions.Select(x => x.Text)),
                TimeToCook = GetTime(data.TotalTime),
            };
        }

        private static Guid GenerateGuidFromUrl(Uri uri)
        {
            // Denna behöver normaliseras, bookmarks, query-parametrar osv behöver tas bort.
            var url = uri.GetLeftPart(UriPartial.Path).TrimEnd('/');

            var bytes = Encoding.UTF8.GetBytes(url);
            var hasher = MD5.Create();
            var hash = hasher.ComputeHash(bytes);

            return new Guid(hash);
        }

        private static TimeSpan? GetTime(string formattedTime)
        {
            try
            {
                return XmlConvert.ToTimeSpan(formattedTime);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
