using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
             String source = "Pictures";
            String destination = "E://Users//Pavan";
            try
            {

                if (File.Exists(source))
                {

                    File.Copy(source + "20170809_211254.jpg", destination + "Copyingitem.jpg");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("copied successfully");
        }
    }
}
