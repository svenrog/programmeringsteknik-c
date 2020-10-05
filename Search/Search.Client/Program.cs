using CommandLine;
using Elasticsearch.Net;
using Search.Client.Options;
using Search.Client.Services;
using Search.Common.Models;
using Search.Common.Services;
using System;
using System.Collections.Generic;
using Error = CommandLine.Error;

namespace Search.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<SearchOptions, IndexOptions>(args)
                          .MapResult<SearchOptions, IndexOptions, object>(Search, Index, Error);
        }

        static object Search(SearchOptions options)
        {
            var client = SearchClientFactory.CreateClient(options);

            // 1. Hitta recept som innehåller ordet "fisk"
            // 2. Hitta recept som är upplagda av Per Morberg
            // 3. Hitta recept baserat på något som innehåller söksträng från parameter.
            // 4. Sortera sökträffarna från föregående efter rating.

            return 0;
        }

        static object Index(IndexOptions options)
        {
            RecipeDocument recipe;

            try
            {
                recipe = RecipeFactory.CreateFrom(options.Url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }

            var client = SearchClientFactory.CreateClient(options);

            var response = client.Index(recipe);

            Console.WriteLine($"Index: {FormatApiCall(response.ApiCall)}");

            return 0;
        }

        static object Error(IEnumerable<Error> errors)
        {
            foreach (var error in errors)
            {
                Console.WriteLine(error.ToString());
            }

            return 1;
        }

        static string FormatApiCall(IApiCallDetails details)
        {
            var status = details.HttpStatusCode;
            var wasSuccess = details.Success;
            var path = details.Uri.AbsolutePath;

            return $"Response for '{path}', success: {wasSuccess}, status: {status}";
        }
    }
}
