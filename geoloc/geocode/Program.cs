using NGeoNames;
using NGeoNames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

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
            GavlePositions();
            // 2. Hitta alla platser inom 200 km radie till Uppsala (59.858562, 17.638927), sorterat på avstånd.
            UppsalaPositions();
            // 3. Lista x platser baserat på användarinmatning.
            UserInputPositions();
        }
        static void GavlePositions()
        {
            var gavle = _locationNames.Where(n => n.Name.Equals("Gävle")).First();
            var neighbours = _reverseGeoCodingService.NearestNeighbourSearch(gavle, 10);
            neighbours = neighbours.OrderBy(p => p.Name);
            Console.WriteLine("De tio närmsta platserna till punkt Gävle: ");
            foreach (var place in neighbours)
            {
                Console.WriteLine(place.Name);
            }
        }
        static void UppsalaPositions()
        {
            double radius = 200 * 1000;
            var uppsala = _locationNames.Where(n => n.Name.Equals("Uppsala")).First();
            var radialSerarch = _reverseGeoCodingService.RadialSearch(uppsala, radius);
            radialSerarch = radialSerarch.OrderBy(p => p.DistanceTo(uppsala));
            Console.WriteLine("\nAlla platser inom 200 km radie från Uppsala: ");
            foreach (var place in radialSerarch)
            {
                Console.WriteLine(place.Name);
            }
        }
        static void UserInputPositions()
        {
            Console.Write("Vilken plats vill du hitta grannar till? \nPlats: ");
            var userPlace = Console.ReadLine();
            Console.Write("Inom vilken radie vill du hitta grannar?\nAnge radie:");
            var radialOfNeighbours = Convert.ToDouble(Console.ReadLine())*1000;
            var place = _locationNames.Where(n => n.Name.Equals(userPlace)).First();
            var radialSearch = _reverseGeoCodingService.RadialSearch(place, radialOfNeighbours).ToList();
            
            Console.WriteLine($"\nAlla platser inom {radialOfNeighbours/1000} km radie från {userPlace}: ");
            foreach (var neighbour in radialSearch)
            {
                Console.WriteLine(neighbour.Name);
            }
        }
    }
}
