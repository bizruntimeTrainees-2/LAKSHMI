using System;
using System.IO;
namespace StreamReader3
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader("E:Lakshmi.txt"))
            {

                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }

            }
        }

    }
}
