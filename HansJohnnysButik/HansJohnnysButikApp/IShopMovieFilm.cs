using System;
using System.Collections.Generic;
using System.Text;

namespace HansJohnnysButikApp
{
    public interface IShopMovieFilm
    {
        List<Music> MusicArea { get; }
        List<Movies> MovieArea { get; }
    }
}
