using System;
using System.Threading;
using System.Collections.Concurrent;
namespace BlockingCollection3
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity:6);
            b.Add(1);
            b.Add(2);
            b.Add(3);
            int item = b.Take();
            
            if (b.TryTake(out item, TimeSpan.FromSeconds(3)))
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("No item removed");
            }
        }
    }
}
