
using System.Net;
using System.Net.Sockets;

namespace ChatApp
{
    class ConnectionService
    {

        private TcpListener? server;
        private TcpClient? client;
        public event Action? Connected;

        public TcpClient? Client => client;

        public bool IsConnected => client?.Connected ?? false;

        // waits for client as a server
        public async Task StartServerAsync(int port)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            client = await server.AcceptTcpClientAsync(); // wait until a client connects
            Connected?.Invoke();
        }

        // connect to server as a client
        public async Task StartConnectionAsync(string host, int port)
        {
            client = new TcpClient();
            try
            {
                await client.ConnectAsync(host, port);
                Connected?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection failed!");
            }
        }
    }
}
