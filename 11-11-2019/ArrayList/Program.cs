using System;
using System.Collections;
namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            list1.Add(1);
            list1.Add(5);
            list1.Add("one");
            list1.Add("hat");
            list1.Add("elephant");

            IList list2 = new ArrayList()
            {
                100,"bangle",500
            };

            list1.AddRange(list2);
            for (int i = 0; i < list1.Count; i++)
            {

                Console.WriteLine(list1[i]);
            }
        }
    }
}
