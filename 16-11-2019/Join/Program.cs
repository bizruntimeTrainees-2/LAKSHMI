using System;
using System.Threading;
namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            t1.Start();
            Thread t2 = new Thread(Method2);
            t2.Start();

            t1.Join();
            Console.WriteLine("After thread1");

            t2.Join();
            Console.WriteLine("After Thread2");
            Console.ReadKey();
        }


        public static void Method2(object obj)
        {
            Console.WriteLine("Thread1 is executed");
        }
        public static void Method1(object obj)
        {
            Console.WriteLine("thread2 is executed");
        }
    }
}
    
    

