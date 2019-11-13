using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threaded.Tasks;

namespace Linq
{
    public class Distinct
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1,3,5,7,9,7,5,9,15,12,18,21,18
            };
                var querySyntax = (from num in numbers
                                    select num).Distinct();

                foreach(var num in querySyntax)
            {
                    Console.WriteLine(num);
            }
            Console.ReadLine();
    }
}
}