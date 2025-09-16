using ChatApp;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        private Int32 port = 5000;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            ChatService chat = new ChatService();
            chat.SendMessage(this.chatInputFrame.Text);

        }

        private async void BtnConnect_Click(object sender, EventArgs e)
        {
            ConnectionService conn = new ConnectionService();

            await conn.StartConnectionAsync(ipAdressFrame.Text, int.Parse(portFrame.Text));


            if (conn.IsConnected)
            {
            }
            else
            {
            }

        }

        private async void BtnStartServer_Click(object sender, EventArgs e)
        {
            ConnectionService conn = new ConnectionService();

            await conn.StartServerAsync(port);


            if (conn.IsConnected)
            {
                MessageBox.Show("Client connected!");
            }
        }
    }
}
