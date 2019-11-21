using System;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
namespace StreamReader5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Example();          //start computation
                string result = Console.ReadLine();         //it handles user input
                Console.WriteLine("you typed:" + result);
            }
        }
        static async void Example()
        {           //this method runs asynchronously
            int t = await Task.Run(() => Allocate());
            Console.WriteLine("compute:" + t);
        }
        static int Allocate()
        {       //computing total count of digits in a string
            int size = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }
    }
}

