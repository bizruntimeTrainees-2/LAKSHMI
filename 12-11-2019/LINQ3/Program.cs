using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "apple","bat","cat","dog","eagle","fox"
            };
            var mixedSyntax = (from obj in list
                               select obj).Max();
            foreach(var item in mixedSyntax)
            {
                Console.Write(item);
            }
            
        }
    }
}
