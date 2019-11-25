using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
public class SocketListener     // Socket Listener acts as a server and listens to the incoming   
// messages on the specified port and protocol.  
{
    public static void Main(string[] args)
    {
        SocketServer();
    }


    public static void SocketServer()
    {   
        IPHostEntry host = Dns.GetHostEntry("localhost");   // Host IP Address that is used to establish a connection
        IPAddress ipAddress = host.AddressList[0];      // If a host has multiple addresses, you will get a list of addresses 
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);


        try
        {

            // Create a Socket that will use Tcp protocol      
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp); //it receives any messages captured from the client
            listener.Bind(localEndPoint);       // A Socket must be associated with an endpoint using the Bind method
            // Specify how many requests a Socket can listen before it gives Server busy response.  
            // We will listen 10 requests at a time  
            listener.Listen(10);

            Console.WriteLine("Waiting for a connection...");
            Socket handler = listener.Accept(); //receives the requests

            // Incoming data from the client.    
            string data = null;
            byte[] bytes = null;

            while (true)
            {
                bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf("text") > -1)
                {
                    break;
                }
            }

            Console.WriteLine("Text received : {0}", data);

            byte[] msg = Encoding.ASCII.GetBytes(data);
            handler.Send(msg);
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        Console.ReadKey();
    }
}
