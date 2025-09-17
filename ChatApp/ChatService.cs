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

        // TODO: Hier möchte ich eine Nachricht senden. WIP - APP stürtzt momentan ab
        public void SendMessage(string message) 
        {
            stream.Write(Encoding.ASCII.GetBytes(message), 0, message.Length);
        }

        // TODO : Hier möchte ich eine Nachricht empfangen. WIP
        public async Task<string> ReceiveMessageAsync() 
        {
            stream = client.GetStream().ToString();

            return stream;
        }
    }
}
