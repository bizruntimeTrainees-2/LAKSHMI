using System;
using System.Threading;
using System.Collections.Concurrent;
namespace ConcurrentBag1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(4);
            bag.Add(6);
            bag.Add(8);
            bag.Add(10);
            bag.Add(12);

            int result;
            if(bag.TryPeek(out result))     //it returns the most recently added element
            {
                Console.WriteLine("TryPeek: " + result);
            }
            if(bag.TryTake(out result))     //it returns and removes the most recently added element
            {
                Console.WriteLine("TryTake: " + result);
            }
            if (bag.TryPeek(out result))
            {
                Console.WriteLine("TryPeek: " + result);
            }

        }
    }
}

//it is used for storing the elements.