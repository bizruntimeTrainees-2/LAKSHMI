using System;
using System.Collections.Generic;
namespace Sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1", "lion");
            names.Add("7", "tiger");
            names.Add("3", "cheetah");
            names.Add("5", "leopard");

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
