using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace RecipeScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klockan är 03:35, måste bara få detta att funka, till imorgon.

            var lsit = new List<Recipe>();

            var r = (HttpWebRequest)WebRequest.Create("https://www.koket.se/smorstekt-torskrygg-med-pestoslungad-blomkal-och-sparris");
            var tmp = new Recipe();

            using (var rr = r.GetResponse())
            {
                var htd = new HtmlDocument();

                using (var c = rr.GetResponseStream())
                {
                    using (var tmp2 = new MemoryStream())
                    {
                        c.CopyTo(tmp2);
                        tmp2.Seek(0, SeekOrigin.Begin);

                        htd.Load(tmp2);

                        var d = JsonConvert.DeserializeObject<JObject>(htd.GetElementbyId("__NEXT_DATA__").InnerHtml)
                                                        .SelectToken("props.pageProps.structuredData[?(@['\x40type']=='Recipe')]") as JObject;

                        tmp.N = (string)d["name"].ToObject(typeof(string));
                        tmp.D = (string)d["description"].ToObject(typeof(string));
                        tmp.I = (string)d["image"].ToObject(typeof(string));

                        tmp.Ig = new List<Ingredient>();

                        foreach (var tm3p in d["recipeIngredient"] as JArray)
                        {
                            if (double.TryParse(((string)tm3p).Split(' ')[0], out var a))
                            {
                                var n = ((string)tm3p).Split(' ').Skip(2);

                                tmp.Ig.Add(new Ingredient { A = a, U = ((string)tm3p).Split(' ')[1], N = string.Join(" ", n) });
                            }
                            else
                            {
                                tmp.Ig.Add(new Ingredient { N = (string)tm3p });
                            }
                        }

                        tmp.Step = new List<string>();

                        foreach (var t4mp in d["recipeInstructions"] as JArray)
                        {
                            tmp.Step.Add(new Regex("<[^>]*(>|$)").Replace((string)t4mp["text"], string.Empty));
                        }
                    }
                }
            }

        }
    }

    class Recipe
    {
        public string N { get; set; }
        public string I { get; set; }
        public string D { get; set; }

        public List<Ingredient> Ig { get; set; }
        public List<string> Step { get; set; }
    }

    class Ingredient
    {
        public double A { get; set; }
        public string U { get; set; }
        public string N { get; set; }
    }

    class Steps
    {

    }
}
