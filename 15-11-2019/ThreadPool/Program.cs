using System;
using System.Threading;

using System.Diagnostics;

namespace ThreadPooling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch t = new Stopwatch();
            Console.WriteLine("Thread Pool Method");
            t.Start();
            ProcessWithThreadPoolMethod();
            t.Stop();
            Console.WriteLine("The Time consumed by ProcessWithThreadPoolMethod" + t.ElapsedTicks.ToString());
            t.Reset();
            Console.WriteLine("Thread Method");
            t.Start();
            ProcessWithThreadMethod();
            t.Stop();
            Console.WriteLine("The time consumed by ProcessWithThreadMethod" + t.ElapsedTicks.ToString());
        }
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process));
            }
        }

        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        static void Process(object callback)
        {

        }

    }
}

    
