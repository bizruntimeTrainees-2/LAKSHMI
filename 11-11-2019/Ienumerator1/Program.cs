using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ienumerator1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,3,5,7,9,11,13,15,17,19
            };
            IEnumerable<int> querySyntax = from obj in list
                                           where obj > 5
                                           select obj;
            foreach (var item in querySyntax)
            {

                Console.WriteLine(item);
            }
        }
    }
}
