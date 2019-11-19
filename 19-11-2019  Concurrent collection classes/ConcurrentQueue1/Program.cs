using System;
using System.Threading;
using System.Collections.Concurrent;
namespace ConcurrentQueue1
{
    class Program
    {
        static ConcurrentQueue<string> cq = new ConcurrentQueue<string>();
        static void Main(string[] args)
        {
            cq.Enqueue("van");
            cq.Enqueue("bus");
            cq.Enqueue("car");
            cq.Enqueue("vehicle");

            Console.WriteLine(string.Join(",", cq.ToArray()));

            string resultPeek;
            if(cq.TryPeek(out resultPeek))
            {
                Console.WriteLine("TryPeek: " + resultPeek);
            }
            string resultDequeue;
            if(cq.TryDequeue(out resultDequeue))
            {
                Console.WriteLine("TryDequeue: " + resultDequeue);
            }
            Console.WriteLine(string.Join(",",cq.ToArray()));
        }
    }
}
