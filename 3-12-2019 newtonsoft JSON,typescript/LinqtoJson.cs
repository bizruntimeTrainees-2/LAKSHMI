using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace LinqJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            JArray array = new JArray();
           array.Add("lakshmi");
            array.Add(new DateTime(1998, 11, 22));

            JObject o = new JObject();
            o["MyArray"] = array;

            string json = o.ToString();
            Console.WriteLine(json);
        }
    }
}
