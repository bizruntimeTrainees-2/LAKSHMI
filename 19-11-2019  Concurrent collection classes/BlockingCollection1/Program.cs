using System;
using System.Collections.Concurrent;
namespace BlockingCollection1
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity: 5);
            b.Add(1);
            b.Add(2);

            if(b.TryAdd(3,TimeSpan.FromSeconds(2)))
            {
                Console.WriteLine("items are added");
            }
            else
            {
                Console.WriteLine("items are not added");
            }
            
        }
    }
}
