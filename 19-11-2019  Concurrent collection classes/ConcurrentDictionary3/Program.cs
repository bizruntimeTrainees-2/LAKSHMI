using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace ConcurrentDictionary3
{
    class Program
    {
       static ConcurrentDictionary<string, int> cd = new ConcurrentDictionary<string, int>();
        static void Main(string[] args)
        {
            cd.TryAdd("watch", 2);
            cd.TryAdd("hand", 4);

            cd.TryUpdate("watch", 500, 2);
            cd.TryUpdate("watch", 300, 5);
            Console.WriteLine(cd["watch"]);
        }
    }
}
