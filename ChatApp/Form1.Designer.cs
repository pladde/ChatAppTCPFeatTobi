namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chatFrame = new ListBox();
            chatInputFrame = new TextBox();
            btnSend = new Button();
            portFrame = new TextBox();
            ipAdressFrame = new TextBox();
            lblIPAddress = new Label();
            lvlPort = new Label();
            btnConnect = new Button();
            btnStartServer = new Button();
            SuspendLayout();
            // 
            // chatFrame
            // 
            chatFrame.FormattingEnabled = true;
            chatFrame.ItemHeight = 15;
            chatFrame.Location = new Point(35, 76);
            chatFrame.Name = "chatFrame";
            chatFrame.Size = new Size(425, 289);
            chatFrame.TabIndex = 0;
            // 
            // chatInputFrame
            // 
            chatInputFrame.Location = new Point(38, 380);
            chatInputFrame.Name = "chatInputFrame";
            chatInputFrame.Size = new Size(341, 23);
            chatInputFrame.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(385, 380);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += BtnSend_Click;
            // 
            // portFrame
            // 
            portFrame.Location = new Point(181, 34);
            portFrame.Name = "portFrame";
            portFrame.Size = new Size(53, 23);
            portFrame.TabIndex = 3;
            // 
            // ipAdressFrame
            // 
            ipAdressFrame.Location = new Point(35, 33);
            ipAdressFrame.Name = "ipAdressFrame";
            ipAdressFrame.Size = new Size(137, 23);
            ipAdressFrame.TabIndex = 4;
            // 
            // lblIPAddress
            // 
            lblIPAddress.AutoSize = true;
            lblIPAddress.Location = new Point(38, 16);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(64, 15);
            lblIPAddress.TabIndex = 5;
            lblIPAddress.Text = "IP-Address";
            // 
            // lvlPort
            // 
            lvlPort.Location = new Point(181, 19);
            lvlPort.Name = "lvlPort";
            lvlPort.Size = new Size(100, 12);
            lvlPort.TabIndex = 0;
            lvlPort.Text = "Port";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(240, 34);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += BtnConnect_Click;
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(385, 33);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(75, 23);
            btnStartServer.TabIndex = 2;
            btnStartServer.Text = "start server";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += BtnStartServer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 421);
            Controls.Add(lvlPort);
            Controls.Add(lblIPAddress);
            Controls.Add(ipAdressFrame);
            Controls.Add(portFrame);
            Controls.Add(btnStartServer);
            Controls.Add(btnConnect);
            Controls.Add(btnSend);
            Controls.Add(chatInputFrame);
            Controls.Add(chatFrame);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox chatFrame;
        private TextBox chatInputFrame;
        private Button btnSend;
        private TextBox portFrame;
        private TextBox ipAdressFrame;
        private Label lblIPAddress;
        private Label lvlPort;
        private Button btnConnect;
        private Button btnStartServer;
    }
}
