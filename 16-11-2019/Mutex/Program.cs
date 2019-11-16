using System;
using System.Threading;
using System.Threading.Tasks;
namespace Mutexclass
{
    class Program
    {
       private static  Mutex mutex = new Mutex();
       const int numhits = 1;
       const int numThreads = 5;
        static void MyThread()
        {
            for(int i = 0; i < numhits; i++)
            {
                Run();
            }
        }
        static void Run()
        {
            mutex.WaitOne();
            Console.WriteLine("{0} has entered in the run", Thread.CurrentThread.Name);
            Console.WriteLine("{0} has left the run", Thread.CurrentThread.Name);
            mutex.ReleaseMutex();
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < numThreads; i++)
            {
                Thread t = new Thread(MyThread);
                t.Name = String.Format("Threads{0}", i + 1);
                t.Start();

            }
            Console.Read(); 
        }
    }
}
