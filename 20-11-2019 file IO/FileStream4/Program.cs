using System;
using System.Threading.Tasks;
using System.Text;
using System.IO;
namespace FileStream4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E://Lakshmi.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i =fs.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            fs.Close();
        }
    }
}
