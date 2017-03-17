using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace PacketCrafter
{
    public partial class frmMainUI : Form
    {
        public frmMainUI()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            if (this.cmbType.Text == "TCP")
            {
                try
                {
                    // TCP socket code goes here
                    byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(txtPayload.Text);
                    string ipAddress = txtDestAddress.Text;
                    int portNumber = Convert.ToInt32(txtDestPort.Text);

                    IPEndPoint otherServer = new IPEndPoint(IPAddress.Parse(ipAddress), portNumber);

                    Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    client.SendTimeout = 10000;
                    client.ReceiveTimeout = 10000;
                    client.Connect(otherServer);
                    client.Send(packetData);
                    txtHelper.Text = "Packet sent";
                }
                catch
                {
                    txtHelper.Text = "There was a problem sending the packet";
                }
            
            }

            if (this.cmbType.Text == "UDP")
            {
                // UDP socket code goes here
                byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(txtPayload.Text);
                string ipAddress = txtDestAddress.Text;
                int portNumber = Convert.ToInt32(txtDestPort.Text);

                IPEndPoint otherServer = new IPEndPoint(IPAddress.Parse(ipAddress), portNumber);

                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                client.SendTo(packetData, otherServer);
                txtHelper.Text = "Packet sent";
            }

            if (this.cmbType.Text == "DNS Request")
            {
                // DNS request code goes here
                txtPayload.Text = "Enter domain here";
                txtDestPort.Text = "53";
                IPHostEntry hostinfo = Dns.GetHostEntry(txtPayload.Text);
                txtHelper.Text = "Packet sent";
            }

            if (this.cmbType.Text == "ICMP")
            {
                // ICMP socket code goes here
                // Socket access might be blocked for this
                txtPayload.Text = "ICMP echo";
                txtDestPort.Text = "1";
                byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(txtPayload.Text);
                string ipAddress = txtDestAddress.Text;
                int portNumber = 1;

                IPEndPoint otherServer = new IPEndPoint(IPAddress.Parse(ipAddress), portNumber);

                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
                client.SendTo(packetData, otherServer);
                txtHelper.Text = "Packet sent";

            }
        }

        private void frmMainUI_Load(object sender, EventArgs e)
        {

        }

        private void cmdViewPacket_Click(object sender, EventArgs e)
        {
            string plainText = txtDestAddress.Text + txtDestPort.Text + cmbType.Text + txtPayload.Text;
            byte[] byteCode = System.Text.Encoding.ASCII.GetBytes(plainText);
            string thePacket = BitConverter.ToString(byteCode);

            txtPacket.Text = thePacket;

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 2)
            {
                txtPayload.Text = "Enter domain here.";
                txtDestPort.Text = "53";
            }

            if (cmbType.SelectedIndex == 3)
            {
                txtPayload.Text = "ICMP echo";
                txtDestPort.Text = "1";
                txtHelper.Text = "Application must run with admin privileges";
            }


        }
    }
}
