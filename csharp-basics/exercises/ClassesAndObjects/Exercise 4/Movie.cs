using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Movie
    {
        public string _title;
        public string _studio;
        public string _rating;

        public Movie (string title, string studio, string rating)
        {
            this._title = title;
            this._studio = studio;
            this._rating = rating;
        }

        public Movie (string title, string studio)
        {
            this._title = title;
            this._studio = studio;
            this._rating = "PG";
        }
    }
}
