using System;
using System.Collections;
namespace Arraylist1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList list = new ArrayList()
            {
                1,
                "lakky",
                "nandu",
                "lavanya",
                3
            };
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach(var val in list)
            {
                Console.WriteLine(val);
            }
        }
    }
}
