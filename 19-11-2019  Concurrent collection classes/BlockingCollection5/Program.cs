using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
namespace BlockingCollection5
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity: 10);
            Task producerThread = Task.Factory.StartNew(() =>

            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    b.Add(i);
                }
                b.CompleteAdding();
            });
            foreach(int item in b.GetConsumingEnumerable())
            {
                Console.WriteLine(item);
            }
        
        }
    }
}
