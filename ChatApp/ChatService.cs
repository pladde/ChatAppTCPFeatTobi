using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;


namespace ChatApp
{
    class ChatService
    {
        private TcpClient client;
        private NetworkStream stream;

        public void SendMessage(string message) 
        {
            stream.Write(Encoding.ASCII.GetBytes(message), 0, message.Length);
        }

        public async Task<string> ReceiveMessageAsync() 
        {
            stream = client.GetStream();

            return stream.ToString();
        }
    }
}
