using System;
using System.Collections.Generic;
namespace LinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<String>();
            names.AddLast("lakky");
            names.AddLast("Bujji");
            names.AddLast("puppy");
            names.AddLast("Ruby");

            LinkedListNode<String> node = names.Find("Bujji");
            names.AddBefore(node, "sana");
            names.AddBefore(node, "stella");

            foreach(var name in names)
            {

                Console.WriteLine(name);
            }
           
        }
    }
}
