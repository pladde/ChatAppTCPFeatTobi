using System.Drawing;
using System.Windows.Forms;

namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chatFrame = new System.Windows.Forms.ListBox();
            this.chatInputFrame = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.portFrame = new System.Windows.Forms.TextBox();
            this.ipAdressFrame = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lvlPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatFrame
            // 
            this.chatFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatFrame.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3136");
            this.chatFrame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatFrame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatFrame.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F8F8F2");
            this.chatFrame.FormattingEnabled = true;
            this.chatFrame.ItemHeight = 17;
            this.chatFrame.Location = new System.Drawing.Point(20, 75);
            this.chatFrame.Name = "chatFrame";
            this.chatFrame.Size = new System.Drawing.Size(460, 272);
            this.chatFrame.TabIndex = 999;
            // 
            // chatInputFrame
            // 
            this.chatInputFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatInputFrame.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3136");
            this.chatInputFrame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatInputFrame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatInputFrame.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F8F8F2");
            this.chatInputFrame.Location = new System.Drawing.Point(20, 360);
            this.chatInputFrame.Multiline = true;
            this.chatInputFrame.Name = "chatInputFrame";
            this.chatInputFrame.Size = new System.Drawing.Size(370, 30);
            this.chatInputFrame.TabIndex = 5;
            this.chatInputFrame.Text = "Write your message here...";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.ColorTranslator.FromHtml("#5865F2");
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(400, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 30);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // portFrame
            // 
            this.portFrame.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3136");
            this.portFrame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portFrame.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F8F8F2");
            this.portFrame.Location = new System.Drawing.Point(170, 40);
            this.portFrame.Name = "portFrame";
            this.portFrame.Size = new System.Drawing.Size(60, 16);
            this.portFrame.TabIndex = 2;
            // 
            // ipAdressFrame
            // 
            this.ipAdressFrame.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3136");
            this.ipAdressFrame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipAdressFrame.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F8F8F2");
            this.ipAdressFrame.Location = new System.Drawing.Point(20, 40);
            this.ipAdressFrame.Name = "ipAdressFrame";
            this.ipAdressFrame.Size = new System.Drawing.Size(140, 16);
            this.ipAdressFrame.TabIndex = 1;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIPAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");
            this.lblIPAddress.Location = new System.Drawing.Point(20, 20);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(64, 15);
            this.lblIPAddress.TabIndex = 5;
            this.lblIPAddress.Text = "IP Address";
            // 
            // lvlPort
            // 
            this.lvlPort.AutoSize = true;
            this.lvlPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlPort.ForeColor = System.Drawing.ColorTranslator.FromHtml("#99AAB5");
            this.lvlPort.Location = new System.Drawing.Point(170, 20);
            this.lvlPort.Name = "lvlPort";
            this.lvlPort.Size = new System.Drawing.Size(30, 15);
            this.lvlPort.TabIndex = 0;
            this.lvlPort.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.ColorTranslator.FromHtml("#4F545C");
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(240, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 25);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartServer.BackColor = System.Drawing.ColorTranslator.FromHtml("#4F545C");
            this.btnStartServer.FlatAppearance.BorderSize = 0;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.Location = new System.Drawing.Point(370, 35);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(110, 25);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
            this.ClientSize = new System.Drawing.Size(500, 410);
            this.Controls.Add(this.lvlPort);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.ipAdressFrame);
            this.Controls.Add(this.portFrame);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chatInputFrame);
            this.Controls.Add(this.chatFrame);
            this.Name = "Form1";
            this.Text = "Simple Chat App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox chatFrame;
        private System.Windows.Forms.TextBox chatInputFrame;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox portFrame;
        private System.Windows.Forms.TextBox ipAdressFrame;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lvlPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnStartServer;
    }
}