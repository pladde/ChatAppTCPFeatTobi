using System.Net.Sockets;
using System.Text;

namespace ChatApp
{
    class ChatService
    {
        private TcpClient client;
        private NetworkStream stream;

        public ChatService(TcpClient connectedClient)
        {
            client = connectedClient;
            stream = client.GetStream();
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        public async Task<string> ReceiveMessageAsync()
        {
            byte[] data = new byte[256];
            int bytes = await stream.ReadAsync(data);
            return Encoding.ASCII.GetString(data, 0, bytes);
        }
    }
}