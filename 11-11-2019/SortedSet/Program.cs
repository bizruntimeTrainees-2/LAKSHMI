using System;
using System.Collections.Generic;
namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();
            names.Add("lakshmi");
            names.Add("deeksha");
            names.Add("manisha");
            names.Add("nandini");
            names.Add("deeksha");   //it cannot be added because it is duplicate 

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
