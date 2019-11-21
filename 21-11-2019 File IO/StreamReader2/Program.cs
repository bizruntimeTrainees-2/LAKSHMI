using System;
using System.Threading;
using System.Threading.Tasks;

using System.IO;
namespace StreamReader2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E:Lakshmi.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string line = "";
            while((line = sr.ReadLine()) !=  null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
        }
    }
}
