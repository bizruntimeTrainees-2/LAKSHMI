using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace TextReader1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "E:Lakkyraj.txt";
            using(TextReader tr = File.OpenText(file))
            {
                Console.WriteLine(tr.ReadToEnd());              //it will read upto end
               // Console.WriteLine(tr.ReadLine());             //it will read only one line
            }
            
        }
    }
}
