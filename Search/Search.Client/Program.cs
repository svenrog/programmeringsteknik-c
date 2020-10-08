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

    //ElasticServers används ute i arbetslivet. SKA KUNNA! (Kolla upp EMVP, APIkunnig)
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<SearchOptions, IndexOptions>(args)
                          .MapResult<SearchOptions, IndexOptions, object>(Search, Index, Error);
        }                   //Måste ha return om Parser innehåller .MapResult (Det behöver bara returnera true / false)

        static object Search(SearchOptions options)
        {
            RecipeClient client = SearchClientFactory.CreateClient(options);

            // Denna övning använder ElasticSearch
            // https://www.elastic.co/

            // Dokumentation över hur man ställer frågor
            // https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/writing-queries.html

            // 1. Hitta 20 recept som innehåller ordet "fisk". Kolla guiden ovan.
            // 2. Sortera sökträffarna efter rating.
            // 3. Räkna alla recept som är upplagda av Per Morberg.
            // 4. Hitta 30 recept som tillhör kategorin Bönor.
            // 5. Räkna alla recept som har en tillagningstid på under 10 minuter (tips: TimeSpan lagras som ticks i index).

            //Query är strukturerad sökning queryOnQueryString är

            // Standardsök innehåller 10 st resultat: var result = client.Search(s => s.QueryOnQueryString(options.Query));
            //var result = client.Search(s => s.QueryOnQueryString(options.Query)
            //                                    .Take(20)
            //                                    .Sort(r => r.Descending(d => d.Rating)
            //                                    .Ascending(a => a.Name)));

            // Hur man söker på ett specifikt fält ("Per Morberg") client.Count = träffar på Author(Flera hundra), client.Search = recept med Morberg.
            //var result = client.Search(search => search.Query(
            //                                            query => query.Match(
            //                                                match => match.Field(field => field.Author)
            //                                                                .Query("Per Morberg"))));
            // Samma som ovan fast med QueryOnQueryString
            //var result = client.Count(search => search.QueryOnQueryString("author:\"Per Morberg\""));

            //var result = client.Search(search => search.Query(
            //                                            query => query.Match(
            //                                                match => match.Field(
            //                                                    field => field.Categories)
            //                                                                    .Query("Bönor")))
            //                                                                    .Take(30));

            var result = client.Count(count => count.Query(query => query.Range(
                                                                            range => range.Field(
                                                                                field => field.TimeToCook).LessThan(6000000000))));
                                                                                            

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
