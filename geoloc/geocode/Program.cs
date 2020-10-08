using NGeoNames;
using NGeoNames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace geocode
{
    class Program
    {
        //const måste vara en värdetyp
        static readonly IEnumerable<ExtendedGeoName> _locationNames;
        static readonly ReverseGeoCode<ExtendedGeoName> _reverseGeoCodingService;
        static readonly (double lat, double lng) _gavle;
        static readonly (double lat, double lng) _uppsala;



        static Program()
        {
            _locationNames = GeoFileReader.ReadExtendedGeoNames(".\\Resources\\SE.txt");
            _reverseGeoCodingService = new ReverseGeoCode<ExtendedGeoName>(_locationNames);
            _gavle = (60.674622, 17.141830);
            _uppsala = (59.513175, 17.3820);
        }

        

        //static ValueTuple<double, double> (double lat, double lng)
        //{
        //    (double lat, double lng) coordination = (lat, lng);

        //    return coordination;
        //}
        //static (double, double) GetCoordinates()


        static void Main(string[] args)
        {



            // 1. Hitta de 10 närmsta platserna till Gävle (60.674622, 17.141830), sorterat på namn.
            //var nearbyLocations = _reverseGeoCodingService.NearestNeighbourSearch(gavle.lat, gavle.lng, 10);

            //foreach (var location in nearbyLocations)
            //    foreach (var nameSE in _locationNames)
            //        if (location.Id == nameSE.Id)
            //            // Console.WriteLine(nameSE.Name);

            //            nearbyLocations = nearbyLocations.OrderBy(p => p.Name);
            //foreach (var location in nearbyLocations)
            //{
            //    Console.WriteLine(location.Name + ", " + location.Latitude + ", " + location.Longitude);
            //}
            // 1. Hitta de 10 närmsta platserna till Gävle (60.674622, 17.141830), sorterat på namn.
            Console.WriteLine("1. Gävle");
            ListGavlePostitions();
            
              
            

            //// 2. Hitta alla platser inom 200 km radie till Uppsala (59.858562, 17.638927), sorterat på avstånd.
            Console.WriteLine("2. Uppsala");
            ListUppsalaPostions();


            Console.ReadKey();
            //(double lat, double lng) uppsala = (59.513175, 17.3820);

            //double radius = 200;
            //var locatationsInSector = _reverseGeoCodingService.RadialSearch(uppsala.lat, uppsala.lng, radius);

            //foreach (var location in locatationsInSector)
            //{
            //    foreach (var namesFromTxt in _locationNames)
            //        if (location.Id == namesFromTxt.Id)
            //            Console.WriteLine(namesFromTxt.Name);


            //}
            //Console.ReadKey();
            //// 3. Lista x platser baserat på användarinmatning.
        }

        

        static void ListGavlePostitions()
        {
            var nearbyLocations = _reverseGeoCodingService.NearestNeighbourSearch(_gavle.lat, _gavle.lng, 10);
            nearbyLocations = nearbyLocations.OrderBy(p => p.Name);

            foreach (var positon in nearbyLocations)
            {
                Console.WriteLine($"{positon.Name} lat: {positon.Latitude} lng: {positon.Latitude}");
            }
        }

        static void ListUppsalaPostions()
        {
            var radius = 200 * 1000;
            var nearestUppsala = _reverseGeoCodingService.RadialSearch(_uppsala.lat, _uppsala.lng, radius, 50);
            nearestUppsala = nearestUppsala.OrderBy(x => x.DistanceTo(_uppsala.lat, _uppsala.lng));
            foreach (var position in nearestUppsala)
            {
                var uppsalaDistance = position.DistanceTo(_uppsala.lat, _uppsala.lng);
                Console.WriteLine($"{position.Name}, distance to Uppsala{uppsalaDistance}");
            }
        }


    }
}
