using System;
using System.Collections.Generic;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("lakshmi");
            names.AddLast("nandini");
            names.AddLast("lavanya");
            names.AddFirst("nagaraju");
            names.AddFirst("savithri");

            foreach (var name in names)
            {

                Console.WriteLine(name);
            }
        }
    }
}
