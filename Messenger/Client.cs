using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Messenger
{
    public class Client
    {
        public Client()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);
            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(localEndPoint);
            Console.WriteLine("Socket connected to -> {0} ", sender.RemoteEndPoint?.ToString());

            byte[] messageSent;
            byte[] messageReceived;
            int byteSent;
            int byteRecv;

            System.Console.WriteLine("Enter a message...");

            messageSent = Encoding.ASCII.GetBytes($"{Console.ReadLine()}<EOF>");

            byteSent = sender.Send(messageSent);

            messageReceived = new byte[1024];

            byteRecv = sender.Receive(messageReceived);

            Console.WriteLine("Message from Server -> {0}", Encoding.ASCII.GetString(messageReceived, 0, byteRecv));

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();

        }
    }
}