using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace JSON1
{
    class Program

    {
        //JsonSerializer enables you to control how objects are encoded into JSON.Represents a reader that provides 
        //fast, non-cached, forward-only access to JSON text data

        static void Main(string[] arg)
        {
            Console.WriteLine("Serialization"); //serialization converts object to string.
            Movie movie = new Movie { id = 1, title = "Mission Impossible" };
            string result = JsonConvert.SerializeObject(movie);
            Console.WriteLine(result);

            Console.WriteLine("/nDeserialization"); //deserialisation converts string to object.
            Movie m = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine("id is:" + m.id);
            Console.WriteLine("title is:" + m.title);

            Console.WriteLine("\n Serialization of collection");
            List<Movie> movies = new List<Movie>
            {
                new Movie{ id = 1, title = "titanic" },
        
                new Movie{ id = 2, title = "Black panther" },
                new Movie{ id = 3, title = "deadpool2" }
            };
            string collectionResult = JsonConvert.SerializeObject(movies);
            Console.WriteLine(collectionResult);

            Console.WriteLine("\n Deserialization of collection");
            List<Movie> newMovies = JsonConvert.DeserializeObject<List<Movie>>(collectionResult);
            foreach (var item in newMovies)
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