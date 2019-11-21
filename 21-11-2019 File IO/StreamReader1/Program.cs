using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace StreamReader1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E://Lakshmi.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            String line = sr.ReadLine();        
            Console.WriteLine(line);
        }
    }
}
