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
            var querySyntax = (from rec in list
                                from ch in rec
                                select ch).ToList();

                foreach(var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}