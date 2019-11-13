using System;
using System.Collections.Generic;
namespace LinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "lakky");
            names.Add("2", "avula");
            names.Add("3", "royal");

            foreach (KeyValuePair<string, string> kv in names)
            {

                Console.WriteLine(kv.Key + kv.Value);
            }
        }
    }
}
