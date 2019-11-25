using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;
namespace SocketProgram3
    //basic server connection
{
    class Program
    {
        static Socket acc;
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1224));
            sck.Listen(0);

            byte[] buffer = Encoding.Default.GetBytes("Hello World!!");
            acc.Send(buffer, 0, buffer.Length, 0);

           buffer = new byte[255];
            int rec = acc.Receive(buffer, 0, buffer.Length, 0);
            Array.Resize(ref buffer, rec);
            Console.WriteLine("Received:{0}", Encoding.Default.GetString(buffer));
            Console.Read();
        }
    }
}
