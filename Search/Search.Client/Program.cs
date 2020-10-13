using CommandLine;
using Elasticsearch.Net;
using Search.Client.Options;
using Search.Client.Services;
using Search.Common.Models;
using Search.Common.Services;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
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
            RecipeClient client = SearchClientFactory.CreateClient(options);

            // Denna övning använder ElasticSearch
            // https://www.elastic.co/

            // Dokumentation över hur man ställer frågor
            // https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/writing-queries.html

            // 1. Hitta 20 recept som innehåller ordet "fisk".

            // görs genom arg som inparameter search -q "fisk"


            //var result = client.Search(s => s.QueryOnQueryString(options.Query)
            // .Sort(order => order.Descending(descending => descending.Rating)).Sort(author).Take(20));

            // 2. Sortera sökträffarna efter rating.

            // 3. Räkna alla recept som är upplagda av Per Morberg.

            //var result = client.Search(s => s.QueryOnQueryString(options.Query)(byAuthor => byAuthor.Field(author => author.Author))

            //var result = client.Count(search => search.Query(
            //                query => query.Match(
            //                    match => match.Field(field => field.Author)
            //                    .Query(options.Query))));

            //var result = client.Count(search => search.QueryOnQueryString("author:\"Per Moberg\""));

            // 4. Hitta 30 recept som tillhör kategorin Bönor.

            //var result = client.Search(search => search.QueryOnQueryString("Bönor").);

            // var result = client.Search(search => search.QueryOnQueryString("categories:\"Bönor\""));

            var resultByCookTime = client.Search()

            // 5. Räkna alla recept som har en tillagningstid på under 10 minuter (tips: TimeSpan lagras som ticks i index).

                for (int i = 0; i < 10; i++)
            {

            }
            var result = client.Count(search => search.QueryOnQueryString("timeToCook:\"Bönor\""));

            // .MatchAll());

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

            RecipeClient client = SearchClientFactory.CreateClient(options);

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
            int? status = details.HttpStatusCode;
            bool wasSuccess = details.Success;
            string path = details.Uri.AbsolutePath;

            return $"Response for '{path}', success: {wasSuccess}, status: {status}";
        }
    }
}
