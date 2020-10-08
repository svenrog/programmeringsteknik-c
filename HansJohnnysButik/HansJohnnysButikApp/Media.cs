using System;
using System.Collections.Generic;
using System.Text;

namespace HansJohnnysButikApp
{
    public class Media
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Length { get; set; }
        public double UserGrade { get; set; }
        public int Price { get; set; }
    }
}
