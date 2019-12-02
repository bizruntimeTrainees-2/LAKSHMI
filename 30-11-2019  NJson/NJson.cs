using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSONPARSE
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string>  Hobbies { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student
            {
                Id = 1,
                Name = "Lakshmi",
                Degree = "B.Tech",
                Hobbies = new List<string>
                {
                    "Reading",
                    "playing games",
                    "Watching movies"

                }
            };
            string resultJson = JsonConvert.SerializeObject(std);
            Console.WriteLine(resultJson);  
        }
    }
}
