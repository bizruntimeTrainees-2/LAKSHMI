using System;
namespace Event
{
   
        public delegate string Func(string str);
        public class Event1
        {
            event Func MyEvent;
            public Event1()
            {
                this.MyEvent += new Func(this.HelloUser);
            }
            public string HelloUser(string username)
            {
                return "Hello" + username;
            }

            public static void Main(string[] args)
            {
                Event1 obj = new Event1();
                string result = obj.MyEvent("LAKSHMI ROYAL");
                Console.WriteLine(result);
            }
    }
}