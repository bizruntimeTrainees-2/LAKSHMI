using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

// Listener acts as a server and listens to the incoming messages 
// client uses same ipAddress and same port 
public class Server
{
    public static int Main(String[] args)
    {
       
        return 0;
    }


    public static void StartServer()
    { 
        IPHostEntry host = Dns.GetHostEntry("localhost");   //domain-name-service applications uses Tcp internet services.
        IPAddress ipAddress = host.AddressList[0];  //IP address is used to establish connection.
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);    //it is client-side
        //combination of network address and service protocol is endpoint.

        try
        {

            // Create a Socket that will use Tcp protocol(use Udp also instead of Tcp , with SocketType.Dgram)     
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);   //socket associated with endpoint by bind method
            // Specify how many requests a Socket can listen before it gives Server busy response.  
            // We will listen 10 requests at a time  
            listener.Listen(10);

            Console.WriteLine("Waiting for a connection...");
            Socket handler = listener.Accept();

            // Incoming data from the client.    
            string data = null;
            byte[] bytes = null;

            while (true)
            {   //receive method returns number of bytes from the network.
                bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);   //converting to string type
                if (data.IndexOf("<TEXT>") > -1)
                {
                    break;
                }
            }

            Console.WriteLine("Text received : {0}", data);

            byte[] msg = Encoding.ASCII.GetBytes(data);  //converting to bytes type
            handler.Send(msg);  //here send method returns number of bytes sent to the networking device.
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\n Press any key to continue...");
        Console.ReadKey();
    }
}