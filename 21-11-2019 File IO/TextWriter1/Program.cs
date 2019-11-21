using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.IO;
namespace TextWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "E:Lakkyraj.txt";
            using(TextWriter writer = File.CreateText(file))            //textwriter writes the texy synchronous way
            {
                writer.WriteLine("Hi Hello");
                writer.WriteLine("How are you");
            }
            Console.WriteLine("Entry saved successfully");
        }
    }
}
