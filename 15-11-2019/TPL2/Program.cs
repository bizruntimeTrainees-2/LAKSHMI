using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 100000, i => RunMillionIterations());
                Console.ReadKey();
            }
        public static void RunMillionIterations()
        {
           
            for(int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);
            }
        }
            
        }
    }

