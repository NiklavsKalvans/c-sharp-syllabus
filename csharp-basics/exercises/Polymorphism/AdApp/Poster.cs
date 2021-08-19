using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    class Poster : Advert
    {
        private int _height;
        private int _width;
        private int _copies;
        private int _rate;

        public Poster(int fee, int height, int width, int copies, int rate) : base(fee)
        {
            _height = height;
            _width = width;
            _copies = copies;
            _rate = rate;
        }

        public new int Cost()
        {
            var fee = base.Cost() + (_copies * _rate);
            return fee;
        }

        public override string ToString()
        {
            return $"\nPoster: Cost = {Cost()}";
        }
    }
}
