using System;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies = new Movie[3];
            movies[0] = new Movie("Casino Royale", "Eon Productions", "PG-13");
            movies[1] = new Movie("Glass", "Buena Vista International", "PG-13");
            movies[2] = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine($"{movies[i]._title} {movies[i]._studio} {movies[i]._rating}");
            }

            Movie[] moviesPG = new Movie[movies.Length];
            moviesPG = GetPG(movies);

            for (int i = 0; i < moviesPG.Length; i++)
            {
                Console.WriteLine($"{moviesPG[i]._title} {moviesPG[i]._studio} {moviesPG[i]._rating}");
            }
        }
        public static Movie[] GetPG(Movie[] movies)
        {
            return movies.Where(movie => movie._rating == "PG").ToArray();
        }
    }
}
