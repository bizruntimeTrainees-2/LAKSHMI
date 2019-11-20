using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
namespace FileStream3
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            FileStream fs = new FileStream("E://Lakshmi.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
