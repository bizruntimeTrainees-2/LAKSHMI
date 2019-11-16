using System;
using System.Threading;
using System.Threading.Tasks;
namespace Locking1
{
    class Program
    {
        int totalBalance = 20000;
            Object o = new object();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.WithDraw(5000);
            Console.ReadKey();
        }
        public void WithDraw(int amount)
        {
            lock(o)
            {
                if(amount > totalBalance)
                {
                    Console.WriteLine("Insufficient Balance");
                }
                else
                {
                    totalBalance -= amount;
                    Console.WriteLine("Total balance is:{0}", totalBalance);
                }
                   

            }
        }
    }
}
