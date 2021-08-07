using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _movies;

        public VideoStore()
        {
            _movies = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _movies.Add(new Video (title));
        }
        
        public void Checkout(string title)
        {
            _movies.FirstOrDefault(m => m.Title == title).BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            _movies.FirstOrDefault(m => m.Title == title).BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            _movies.FirstOrDefault(m => m.Title == title).ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach (var movie in _movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }
    }
}
