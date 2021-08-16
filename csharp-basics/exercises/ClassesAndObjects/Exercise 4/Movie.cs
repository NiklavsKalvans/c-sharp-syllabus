using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Movie
    {
        public string title;
        public string studio;
        public string rating;

        public Movie (string title1, string studio1, string rating1)
        {
            title = title1;
            studio = studio1;
            rating = rating1;
        }

        public Movie (string title1, string studio1)
        {
            title = title1;
            studio = studio1;
            rating = "PG";
        }
    }
}
