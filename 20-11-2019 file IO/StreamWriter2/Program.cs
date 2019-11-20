using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace StreamWriter2
{
    class Program
    {
        static void Main(string[] args)
        {
            String file = @"E://Lakky.txt";
            try {
                using (StreamWriter sr = new StreamWriter(file))
                {
                    Console.WriteLine("The following is here");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
