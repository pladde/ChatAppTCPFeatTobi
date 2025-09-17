
namespace ChatApp
{
    public partial class Form1 : Form
    {
        private Int32 port = 5000;
        private ConnectionService? connection;
        private ChatService? chat;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (chat != null)
            {
                chat.SendMessage(chatFrame.Text);
                this.chatFrame.Items.Add("Me: " + chatFrame.Text);
                //chatFrame.Clear();
            }
        }

        private async void BtnConnect_Click(object sender, EventArgs e)
        {
            connection = new ConnectionService();
            await connection.StartConnectionAsync(ipAdressFrame.Text, int.Parse(portFrame.Text));

            if (connection.IsConnected && connection.Client != null)
            {
                MessageBox.Show("Connected to server!");
                chat = new ChatService(connection.Client);
            }
            else
            {
                MessageBox.Show("Connection failed!");
            }
        }

        private async void BtnStartServer_Click(object sender, EventArgs e)
        {
            connection = new ConnectionService();
            await connection.StartServerAsync(int.Parse(portFrame.Text));

            if (connection.IsConnected && connection.Client != null)
            {
                MessageBox.Show("Client connected!");
                chat = new ChatService(connection.Client);

                while (true)
                {
                    string message = await chat.ReceiveMessageAsync();
                    this.chatFrame.Items.Add("Client: " + message);
                    await Task.Delay(1000);
                }
            }
            else
            {
                MessageBox.Show("No client connected!");
            }
        }
    }
}
