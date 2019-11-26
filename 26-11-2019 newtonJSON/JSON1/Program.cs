using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace JSON1
{
    class Program

    {
        private static int id;

        static void Main(string[] args)
        {
            Console.WriteLine("Serialization");
            Movie movie = new Movie { id = 1, title = "Mission Impossible" };
            string result = JsonConvert.SerializeObject(movie);
            Console.WriteLine(result);

            Console.WriteLine("/nDeserialization");
            Movie m = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine("id is:" + m.id);
            Console.WriteLine("title is:" + m.title);

            Console.WriteLine("\n Serialization of collection");
            List<Movie> movies = new List<Movie>
            {
                new Movie{ id = 1, title = "titanic" },
                new Movie{ id = 2, title = "The martain" },
                new Movie{ id = 3, title = "Black panther" },
                new Movie{ id = 4, title = "deadpool2" }
            };
            string collectionResult = JsonConvert.SerializeObject(movies);
            Console.WriteLine(collectionResult);

            Console.WriteLine("\n Deserialization of collection");
            List<Movie> newMovies = JsonConvert.DeserializeObject<List<Movie>>(collectionResult);
            foreach(var item in newMovies)
            {
                Console.WriteLine("id:" + item.id + "\t title:" + item.title);
            }

        }
    }
    class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
    }
}