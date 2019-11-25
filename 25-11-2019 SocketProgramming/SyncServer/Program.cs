using System;
using System.Net;
using System.Text;
using System.Net.Sockets;
namespace SyncServer
{
    class Program
    {
        public static string data = null;
        static void Main(string[] args)
        {
            StartListener();
        }
        static void StartListener()
        {
            byte[] bytes = new byte[255];

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                while(true)
                {
                    Socket handler = listener.Accept();
                    data = null;

                    while(true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        if(data.IndexOf("text") > -1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Text received{0}", data);

                    byte[] msg = Encoding.ASCII.GetBytes(data);
                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Read();
    }
    }
}
