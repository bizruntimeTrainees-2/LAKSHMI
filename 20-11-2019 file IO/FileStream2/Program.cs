using System;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
namespace FileStream2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E://Lakshmi.txt", FileMode.Append);
            byte[] b = Encoding.Default.GetBytes("This is the first File");       //add something to the file
            fs.Write(b, 0, b.Length);
            fs.Close();
            Console.WriteLine("I successfully created the folder:This is the first File");
            Console.ReadKey();
        }
    }
}
