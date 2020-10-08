using NGeoNames;
using NGeoNames.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace geocode.Resources.Extenstions
{
    static class ReversGoeCodingExtenstions
    { 
        public static IEnumerable<ExtendedGeoName> RadialSearch(this ReverseGeoCode<ExtendedGeoName> reservedGeoCode,
            (double Lat, double Lng) position, 
            int maxCount)
        {
            return null;
        }


    }
}
