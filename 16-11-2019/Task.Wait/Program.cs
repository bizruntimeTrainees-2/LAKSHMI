using System;
using System.Threading;
using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
        Task task = Task.Run(() =>
            {
                Random randomNumbers = new Random();
                long sum = 0;
                int count = 1000000;
                for (int i = 1; i <= count; i++)
                {
                    int randomNumber = randomNumbers.Next(0, 101);
                    sum += randomNumber;
                }

                Console.WriteLine("Total:{0}", sum);
                Console.WriteLine("Count: {0}", count);
            });
            task.Wait();

            Console.ReadKey();
        }
    }


