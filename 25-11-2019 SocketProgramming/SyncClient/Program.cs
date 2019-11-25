using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace SyncClient
{
    class Program
    {

        static void Main(string[] args)
        {
            StartServer();
        }
        public static void StartServer()
        {
            byte[] bytes = new byte[255];       //data buffer for incoming data
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                Socket sck = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                //create a Tcp socket
                try
                {
                    sck.Connect(remoteEP);      //connect socket to the remoteEP
                    Console.WriteLine("Socket Connected to {0}", sck.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes("some message");       //data string into byte
                    int byteSent = sck.Send(msg);   //send messages through the socket
                    int byteRec = sck.Receive(bytes);       //receive response from the remote device
                    Console.WriteLine("write any thing {0}", Encoding.ASCII.GetString(bytes, 0, byteRec));
                    sck.Shutdown(SocketShutdown.Both);      //release the socket
                    sck.Close();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
