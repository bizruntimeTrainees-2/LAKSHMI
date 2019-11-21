using System;
using System.IO;
using System.Collections.Generic;
namespace StreamReader4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            using(StreamReader sr = new StreamReader("Lakky.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
