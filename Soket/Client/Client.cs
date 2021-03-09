using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        IPEndPoint ie;
        Socket client;
        int port = 2020;
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Init();
        }

        void Init()
        {
            ie = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(ie);
            }
            catch
            {
                MessageBox.Show("Connect Error !");
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Close()
        {
            client.Close();
        }

        void Send()
        {
            if (rtbInput.Text != string.Empty)
            {
                client.Send(Serialize(rtbInput.Text));
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deseriliaze(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        void AddMessage(string s)
        {
            lvShow.Items.Add(new ListViewItem() { Text = s });
            rtbInput.Clear();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deseriliaze(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }




        private void btReceive_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage("Me : " +rtbInput.Text);
        }
     
    }
}
