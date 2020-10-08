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
        static readonly IEnumerable<ExtendedGeoName> _locationNames;
        static readonly ReverseGeoCode<ExtendedGeoName> _reverseGeoCodingService;
        static readonly (double lat, double lng) _gavlePosition;
        static readonly (double lat, double lng) _uppsalaPosition;
        static readonly IFormatProvider _formatProvider;
        static Program()
        {
            _locationNames = GeoFileReader.ReadExtendedGeoNames(".\\Resources\\SE.txt");
            _reverseGeoCodingService = new ReverseGeoCode<ExtendedGeoName>(_locationNames);

            _gavlePosition = (60.674622, 17.141830);
            _uppsalaPosition = (59.858562, 17.638927);

            _formatProvider = CultureInfo.InvariantCulture;
            
        }

        static void Main(string[] args)
        {
            // 1. Hitta de 10 närmsta platserna till Gävle (60.674622, 17.141830), sorterat på namn.
            Console.WriteLine("1. Gävle");
            Console.WriteLine("--------------");

            ListGavlePositions();
            Console.WriteLine();
            
            // 2. Hitta 50 platser inom 200 km radie till Uppsala (59.858562, 17.638927), sorterat på avstånd.
            
            Console.WriteLine("2. Uppsala");
            Console.WriteLine("------------");
            ListUppsalaPositions();
            Console.WriteLine();

            // 3. Lista x platser baserat på användarinmatning.


            Console.WriteLine("3. Användar stad.");
            Console.WriteLine("------------");

            ListUserPositions(args);
            Console.WriteLine();
        }
        static void ListUserPositions(string [] args)
        {
            double lat = double.Parse(args[0], _formatProvider);
            double lng = double.Parse(args[1], _formatProvider);

            var nearestUser = _reverseGeoCodingService.RadialSearch(lat, lng, 10);

            foreach (var position in nearestUser)
            {
                var userDistance = position.DistanceTo(lat, lng, 10);

                Console.WriteLine($"{position.Name}, Distance: {userDistance}");
            }
        }
        static void ListUppsalaPositions()
        {
            var radius = 200 * 1000;
            var nearestUppsala = _reverseGeoCodingService.RadialSearch(_uppsalaPosition.lat, _uppsalaPosition.lng, radius, 50);

            nearestUppsala = nearestUppsala.OrderBy(x => x.DistanceTo(_uppsalaPosition.lat, _uppsalaPosition.lng));

            foreach (var position in nearestUppsala)
            {
                var uppsalaDistance = position.DistanceTo(_uppsalaPosition.lat, _uppsalaPosition.lng);

                Console.WriteLine($"{position.Name}, Distance to Uppsala: {uppsalaDistance:f02}");
            }
        }

        static void ListGavlePositions()
        {
            var nearestGavle = _reverseGeoCodingService.RadialSearch(_gavlePosition.lat, _gavlePosition.lng, 10);

            nearestGavle = nearestGavle.OrderBy(p => p.Name);

            foreach (var position in nearestGavle)
            {
                System.Console.WriteLine($"{position.Name}, lat: {position.Latitude}, lng: {position.Longitude}");
            }
        }
        //static void ListUppsalaRadius()
        //{
            
        //    var radiusUppsala = _reverseGeoCodingService.RadialSearch(_gavlePosition.lat, _gavlePosition.lng, 200);
        //    radiusUppsala = radiusUppsala.OrderBy(p => p.Name)
        //                                 .ThenBy(p => p.DistanceTo(_uppsalaPosition))
        //                                 .ToList();
        //}
    }
}
