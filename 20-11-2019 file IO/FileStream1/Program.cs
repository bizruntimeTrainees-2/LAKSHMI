using System;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace FileStream1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E://Lakshmi.txt", FileMode.Create);
            fs.Close();
            Console.WriteLine("The created file is present in the E drive");
            Console.ReadKey();
        }
    }
}
