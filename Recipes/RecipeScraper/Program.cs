using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
// Klockan är 03:35, måste bara få detta att funka till imorgon.
var lsit = new List<Recipe>();
try
{
using (var b = new MemoryStream())
{


try
{
var r = (HttpWebRequest)WebRequest.Create(@"https://www.koket.se/smorstekt-torskrygg-med-pestoslungad-blomkal-och-sparris");
using (var rr = r.GetResponse())
{
var tmp = new Recipe();
var htd = new HtmlDocument();
// var cartConverter = ServiceLocator.Current.GetInstance<ICartConverter<ICart, OrderDto>>();
// var cartRecords = cartConverter.Convert(cart);
//
// var valueProvider = ServiceLocator.Current.GetInstance<IMapper>();

// var ociRecords = cartConverter.Convert(cart)
// .Select(x => new OciRecord
//{
//FieldsWithValues = valueProvider.GetValues(x)
//})
//.ToList();

////do some mapping magic

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
                                    var y = new string(new[] { 't', 'e','s','t'});
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
tmp.Step = new List<Step>();
foreach (var t4mp in d["recipeInstructions"] as JArray)
tmp.Step.Add(new Step { Tx = new Regex("<[^>]*(>|$)").Replace((string)t4mp["text"], string.Empty).Replace("\n", " ") });
}

lsit.Add(tmp);
}
}
}
catch(Exception ex)
{
Console.WriteLine($"ERROR: {ex.Message}");
}
                }
//var ociRecords = cart.GetAllLineItems()
//.Select(x => new OciRecord
//{
//FieldsWithValues = new List<FieldWithValue>
//                {
//new FieldWithValue
//{
//FieldDefinition = FieldDefinitions.All.FirstOrDefault(f => f.Name == "VENDORMAT"),
//Value = x.Code
//},
//new FieldWithValue
//{
//FieldDefinition = FieldDefinitions.All.FirstOrDefault(f => f.Name == "QUANTITY"),
//Value = x.Quantity.ToString("###########.###", CultureInfo.InvariantCulture)
//},
//new FieldWithValue
//{
//FieldDefinition = FieldDefinitions.All.FirstOrDefault(f => f.Name == "DESCRIPTION"),
//Value = x.DisplayName
//},
//                }
//})
//.ToList();
                try
                {
var r = (HttpWebRequest)WebRequest.Create(@"https://www.koket.se/vegoburgare-med-tryffelmajonnas");
using (var rr = r.GetResponse())
{
var tmp = new Recipe();
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
tmp.Step = new List<Step>();
foreach (var t4mp in d["recipeInstructions"] as JArray)
tmp.Step.Add(new Step { Tx = new Regex("<[^>]*(>|$)").Replace((string)t4mp["text"], string.Empty).Replace("\n", " ") });
}
lsit.Add(tmp);
}
}
}
catch (Exception ex)
{
Console.WriteLine($"ERROR: {ex.Message}");
}
try
{
var r = (HttpWebRequest)WebRequest.Create(@"https://www.koket.se/smakrik-o-lrisotto-med-vitlo-ksrostad-tomat-citronsparris-och-het-chorizo");
using (var rr = r.GetResponse())
{
var tmp = new Recipe();
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
tmp.Step = new List<Step>();
foreach (var t4mp in d["recipeInstructions"] as JArray)
tmp.Step.Add(new Step { Tx = new Regex("<[^>]*(>|$)").Replace((string)t4mp["text"], string.Empty).Replace("\n", " ") });
}

lsit.Add(tmp);
}
}
}
catch (Exception ex)
{
Console.WriteLine($"ERROR: {ex.Message}");
}
try
{
var r = (HttpWebRequest)WebRequest.Create(@"https://www.koket.se/smorbakad-spetskal-med-krispig-kyckling-och-graddskum");
using (var rr = r.GetResponse())
{
var tmp = new Recipe();
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
tmp.Step = new List<Step>();
foreach (var t4mp in d["recipeInstructions"] as JArray)
tmp.Step.Add(new Step { Tx = new Regex("<[^>]*(>|$)").Replace((string)t4mp["text"], string.Empty).Replace("\n", " ") });
}

lsit.Add(tmp);
}
}
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
for (var x = 0; x < lsit.Count; x++)
{
Console.WriteLine(@$"Recept:" + " " + lsit[x].N);
Console.WriteLine("-------");
Console.WriteLine(lsit[x].D.Trim());
Console.WriteLine("-------");
Console.WriteLine("Ingredienser:");
for (var y = 0; y < lsit[x].Ig.Count; y++)
{
if (lsit[x].Ig[y].A == 0)
Console.WriteLine(lsit[x].Ig[y].N);
else
Console.WriteLine(lsit[x].Ig[y].A.ToString() + " " + lsit[x].Ig[y].U + " " + lsit[x].Ig[y].N);
}
Console.WriteLine("-------");
Console.WriteLine("Steg:");
for (var z = 0; z < lsit[x].Step.Count; z++)
{
Console.WriteLine((z + 1).ToString() + ": " + lsit[x].Step[z].Tx);
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
public string N { get; set; }
public string I { get; set; }
public string D { get; set; }
public List<Ingredient> Ig { get; set; }
public List<Step> Step { get; set; }
}

class Ingredient
{
public double A { get; set; }
public string U { get; set; }
public string N { get; set; }
}

class Step
{
public string T1 { get; set; }
public string Tx { get; set; }
}
}
