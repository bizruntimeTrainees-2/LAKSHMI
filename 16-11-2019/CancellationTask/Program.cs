using System;
using System.Threading;
using System.Threading.Tasks;
namespace CancellationTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            }, token);
            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
          cts.Cancel();
            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
