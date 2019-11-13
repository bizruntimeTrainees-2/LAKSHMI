using System;
using System.Collections;
namespace Hashtable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "lakky");
            ht.Add(2, "bujji");
            ht.Add(3, "royal");
            ht.Add(4, "father");
            ht.Add(5, "mother");

            String strvalue1 = (string)ht[2];
            String strvalue2 = (string)ht[5];
            Console.WriteLine(strvalue1);
            Console.WriteLine(strvalue2);
        }
    }
}
