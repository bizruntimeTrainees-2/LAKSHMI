using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;


namespace ConcurrentDictionary1
{
    class Program
    {
       static  ConcurrentDictionary<int, string> cd = new ConcurrentDictionary<int, string>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
            t1.Start();
            t2.Start();
            Console.ReadLine();
            
        }
        static void M1()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine(cd.TryAdd(i, "M1.added" + i));         }
        }
        static void M2()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine(cd.TryAdd(i, "M2.added" + i));
            }
        }
    }
}
