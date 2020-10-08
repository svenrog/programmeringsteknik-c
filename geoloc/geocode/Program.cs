using NGeoNames;
using NGeoNames.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace geocode
{
    class Program
    {
        static readonly IEnumerable<ExtendedGeoName> _locationNames;
        static readonly ReverseGeoCode<ExtendedGeoName> _reverseGeoCodingService;

        static Program()
        {
            _locationNames = GeoFileReader.ReadExtendedGeoNames(".\\Resources\\SE.txt");
            _reverseGeoCodingService = new ReverseGeoCode<ExtendedGeoName>(_locationNames);
        }

        static void Main(string[] args)
        {
            // 1. Hitta de 10 närmsta platserna till Gävle (60.674622, 17.141830), sorterat på namn.
            ListGavleResults();

            // 2. Hitta alla platser inom 200 km radie till Uppsala (59.858562, 17.638927), sorterat på avstånd.
            //ListUppsalaResults();
            // 3. Lista x platser baserat på användarinmatning.

            Console.WriteLine("Skriv plats och antalet närmsta adresser du vills");
            string place = Console.ReadLine();
            int count = Convert.ToInt32(Console.ReadLine());
            ListUserPossitions(place, count);

        }

        static void ListGavleResults()
        {
            var centerPointGavle = _locationNames.Where(p => p.Name.Equals("Gävle")).First();

            var nearestToGavle = _reverseGeoCodingService.NearestNeighbourSearch(centerPointGavle, 11);
            nearestToGavle = nearestToGavle.Where(x => x != centerPointGavle).OrderBy(p => p.Name);

            foreach (var item in nearestToGavle)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void ListUppsalaResults()
        {
            var centerPointUppsala = _locationNames.Where(p => p.Name.Equals("Uppsala")).First();
            var nearestToUppsala = _reverseGeoCodingService.RadialSearch(centerPointUppsala, 200.0);

            nearestToUppsala = nearestToUppsala.Where(x => x == centerPointUppsala);

            nearestToUppsala = nearestToUppsala.Where(x => x != centerPointUppsala).OrderBy(p => p.DistanceTo(centerPointUppsala));

            foreach (var item in nearestToUppsala)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void ListUserPossitions(string place, int count)
        {
            var centerPointGavle = _locationNames.Where(p => p.Name.Equals(place)).First();

            var nearestToGavle = _reverseGeoCodingService.NearestNeighbourSearch(centerPointGavle, count);
            nearestToGavle = nearestToGavle.OrderBy(p => p.Name);

            foreach (var item in nearestToGavle)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
