﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21521947_ChatUDP
{
    public partial class UDP_client : Form
    {

        string _localPort = "10";
        string _remotePort = "1000";
        UdpClient _applications = new UdpClient();
        Thread _thread;
        bool _exit = false;
        private UDP_server _UDP_server;
        delegate void ClearCacheReceivedData(string Data, string RemoteHost);
        public UDP_client()
        {
            InitializeComponent();
            _UDP_server = new UDP_server();
            _UDP_server.Show(this);
        }

        private void OnbtSendClick(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(txtIpAddress.Text, out ip))
                MessageBox.Show("Please type the right IP address", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SentData();
                lstSent.Items.Insert(0, txtSend.Text);
                txtSend.Clear();
            }
        }
        private void ReceivedData(string Data, string RemoteHost)
        {
            if (lstReceived.InvokeRequired)
            {
                ClearCacheReceivedData clearCacheReceivedData = new ClearCacheReceivedData(ReceivedData);
                lstReceived.Invoke(clearCacheReceivedData, new object[] { Data, RemoteHost });
                return;
            }
            string msg = "";
            msg = "(Receiver: " + RemoteHost + ")" + Data;
            lstReceived.Items.Insert(0, msg);
        }
        private void SentData()
        {
            byte[] msg;
            msg = System.Text.Encoding.UTF8.GetBytes(txtSend.Text);
            _applications.Send(msg, msg.Length, txtIpAddress.Text, int.Parse(_remotePort));
        }
        private void Explore()
        {
            IPAddress ip;
            byte[] msg;
            string str = "";
            string name = Dns.GetHostName();
            ip = Dns.GetHostEntry(name).AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, Convert.ToInt16(_remotePort));
            while (_exit == false)
            {
                Application.DoEvents();
                if (_applications.Available > 0)
                {
                    msg = _applications.Receive(ref ep);
                    str = System.Text.Encoding.UTF8.GetString(msg);
                    ReceivedData(str, ep.Address.ToString());
                }
            }
        }
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            _localPort = this.txtLocalPort.Text;
            _remotePort = this.txtPort.Text;
            _applications = new UdpClient(int.Parse(_localPort));
            _thread = new Thread(Explore);
            _thread.Start();
            this.btSend.Click += OnbtSendClick;
            this.btSend.Enabled = true;
            this.btnConnect.Enabled = false;
            txtIpAddress.ReadOnly = txtLocalPort.ReadOnly = txtPort.ReadOnly = true;
        }

    }
}
