using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "lavanya","lakky","nandini"
            };
            var methodSyntax = list.SelectMany(x => x).ToList();

            foreach(var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}