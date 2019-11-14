using System;

using System.Threading;
namespace Threads1
{
    public class Program
    {
        public  void eat()
        {
            for(int i =0; i < 50; i++)
            {
                Console.WriteLine(i);
            }
        }
           public static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.eat);
            Thread t2 = new Thread(p.eat);
            t1.Start();
            t2.Start();
           
        }
    }
}