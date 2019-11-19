using System;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
namespace BlockingCollection4
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity: 10);
            Task producerThread = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    b.Add(i);
                }
                b.CompleteAdding();         //by producer thread
            });
            Task consumerThread = Task.Run(() =>
            {
                while (!b.IsCompleted)
                {
                    int item = b.Take();
                    Console.WriteLine(item);
                }
            });
            Task.WaitAll(producerThread, consumerThread);
            
        }
    }
}
