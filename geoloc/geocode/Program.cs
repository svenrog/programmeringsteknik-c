using NGeoNames;
using NGeoNames.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace geocode
{
    class Program
    {
        const string _resourcePath = ".\\Resources\\SE.txt";
        static readonly IEnumerable<ExtendedGeoName> _locationNames;
        static readonly ReverseGeoCode<ExtendedGeoName> _reverseGeoCodingService;
        static readonly (double Lat, double Lng) _gavlePosition;
        static readonly (double Lat, double Lng) _uppsalaPosition;
        static readonly IFormatProvider _formatProvider;

        static Program()
        {
            _locationNames = GeoFileReader.ReadExtendedGeoNames(_resourcePath);
            _reverseGeoCodingService = new ReverseGeoCode<ExtendedGeoName>(_locationNames);
            _gavlePosition = (60.674622, 17.141830);
            _uppsalaPosition = (59.858562, 17.638927);
            _formatProvider = CultureInfo.InvariantCulture;
        }

        static void Main(string[] args)
        {
            //var gavle = _locationNames.Where(n => n.Name.Equals("Gävle", StringComparison.OrdinalIgnoreCase) && n.FeatureCode.Equals("PPLC")).First();

            //var results = _reverseGeoCodingService.RadialSearch(gavle, 200);
            //foreach(var el in results)
            //{
            //    Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0}, {1}, {2}, {3:F4}Km)", el.Latitude, el.Longitude, el.Name, el.DistanceTo(gavle)));
            //}


            // 1. Hitta de 10 närmsta platserna till Gävle (60.674622, 17.141830), sorterat på namn.
            ListGavlePos();
            Console.WriteLine();
            // 2. Hitta alla platser inom 200 km radie till Uppsala (59.858562, 17.638927), sorterat på avstånd.
            ListAllUppsala();
            // 3. Lista x platser baserat på användarinmatning.
            ListUserPosition(args);

        }
        static void ListUserPosition(string[] args)
        {
            double lat = double.Parse(args[0], _formatProvider);
            double lng = double.Parse(args[1], _formatProvider);

            var nearestUserPos = _reverseGeoCodingService.RadialSearch(lat, lng, 10);

            foreach (var el in nearestUserPos)
            {
                var userDistance = el.DistanceTo(lat,lng);
                Console.WriteLine($"{el.Name} distance: {userDistance}");
            }
        }

        static void ListGavlePos()
        {
            var nearGavle = _reverseGeoCodingService.RadialSearch(_gavlePosition.Lat, _gavlePosition.Lng, 10);
            nearGavle = nearGavle.OrderBy(o => o.Name);

            foreach (var el in nearGavle)
            {
                Console.WriteLine($"{el.Name} Lat: {el.Latitude} Lng: {el.Longitude}");
            }
        }

        static void ListAllUppsala()
        {
            var radius = 200 * 1000;
            var nearUppsala = _reverseGeoCodingService.RadialSearch(_uppsalaPosition.Lat, _uppsalaPosition.Lng, radius, 50);

            nearUppsala = nearUppsala.OrderBy(o => o.DistanceTo(_uppsalaPosition.Lat, _uppsalaPosition.Lng));
            foreach (var el in nearUppsala)
            {
                Console.WriteLine($"{el.Name} Distance to Uppsala: {el.DistanceTo(_uppsalaPosition.Lat,_uppsalaPosition.Lng)}");
            }
        }

        static void ListByUser()
        {

        }

    }
}
