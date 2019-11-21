using System;
using System.Threading;
using System.IO;

namespace SwSr
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "E://Lakky.txt";
            if(!File.Exists(file))
            {
                using(StreamWriter sw = new StreamWriter(file))         //it will create a file and write in that
                {
                    sw.Write("Hello");
                    sw.Write("how are you?");
                    sw.Write("bye");

                }
            }
            using(StreamReader sr = new StreamReader(file))
            {                                                   //it will read a file
                string s;
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("filw writing and reading successfully");
        }
    }
}
