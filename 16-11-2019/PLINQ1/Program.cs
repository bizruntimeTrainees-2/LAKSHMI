using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
namespace PLINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> val = Enumerable.Range(1, 10000);
            var result = val.AsParallel().Where(i => i % 15 == 0).Select(i => i);
            Stopwatch sq = Stopwatch.StartNew();
            sq.Start();
            foreach( var item in result)
       
                Console.WriteLine(item);
                Console.WriteLine("Time taken for PLINQ processing:" + sq.ElapsedMilliseconds + "ms");
         
            var result1 = val.Where(i => i % 15 == 0).Select(i => i);
            foreach(var item1 in result1)
            
                Console.WriteLine(item1);
                Console.WriteLine("Time taken for LINQ processing:" + sq.ElapsedMilliseconds + "ms");
                Console.ReadLine();
            
        }
    }
}
