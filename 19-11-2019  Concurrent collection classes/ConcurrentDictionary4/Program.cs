using System;
using System.Collections.Concurrent;
using System.Linq;
namespace ConcurrentDictionary4
{
    class Program
    {
        static ConcurrentDictionary<string,int>  cd = new ConcurrentDictionary<string,int>();
        static void Main(string[] args)
        {
            cd.TryAdd("house", 1);
            cd.TryAdd("door", 2);
            cd.TryAdd("decorate", 3);
            cd.TryAdd("look", 4);

            int removedItem;
           bool result =  cd.TryRemove("look", out removedItem);
            Console.WriteLine(removedItem);
        }
    }
}
