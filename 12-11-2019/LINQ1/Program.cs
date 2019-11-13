using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,
                4,
                5,
                2,
                8,
                7,
                9,
                34,
                23
            };
        var querySyntax = from obj in list
                          where obj > 5
                          select obj;
            foreach (var item in querySyntax)
            {

                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
