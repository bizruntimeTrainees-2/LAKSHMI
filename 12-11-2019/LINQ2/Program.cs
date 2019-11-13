using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,4,3,6,2,7,9,78,67,97
            };

            var methodSyntax = list.Where(obj => obj > 7);

            foreach(var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
