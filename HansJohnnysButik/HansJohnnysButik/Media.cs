using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HansJohnnysButik
{
    abstract class Media
    {
        string _title;
        TimeSpan _duration;
        string _format;

        byte _userReview;
        DateTime _releaseDate;

        protected Media()
        {

        }
        protected Media(string title, TimeSpan duration, string format, byte userReview, DateTime releaseYear, price price)
        {
            Title = title;
            Duration = duration;
            Format = format;
            Price = price;//price.ToString("C2", CultureInfo.CurrentCulture);
            UserReview = userReview;
            ReleaseYear = releaseYear;
        }

        public price Price
        {
            get; set;
        }
        public byte UserReview
        {
            get { return _userReview; }
            set
            {
                if (value >= 1 && value <= 10)
                    _userReview = value;
            }
        }
        public string Title
        {
            get; set;
        }
        public TimeSpan Duration
        {
            get; set;
        }
        public string Format
        {
            get; set;
        }
        public DateTime ReleaseYear
        {
            get; set; 
        }

        public struct price
        {
            public decimal _cost;
            public string _currency;
            public string displayCost;

            public price(decimal cost, string currency = "SEK")
            {
                _cost = cost;
                _currency = currency;
                if (_currency.ToUpper() == "SEK")
                    displayCost = _cost.ToString("C2", CultureInfo.CurrentCulture);
                else displayCost = $"{_cost} {_currency}";

            }

        }
    }
}
