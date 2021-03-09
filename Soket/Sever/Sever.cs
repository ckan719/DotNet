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

namespace Sever
{
    public partial class Sever : Form
    {
        Socket server;
        int countClient = 0;
        IPEndPoint ie;
        List<Socket> clientList;
        int port = 2020;
        public Sever()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            cbbClient.Items.Add("All");
            cbbClient.SelectedIndex = 0;
            Init();
            
        }

        public void Init()
        {
            clientList = new List<Socket>();
            ie = new IPEndPoint(IPAddress.Any, port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ie);
            Thread listen = new Thread( () =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        countClient++;
                        cbbClient.Items.Add(countClient);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch {
                    ie = new IPEndPoint(IPAddress.Any, port);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    MessageBox.Show("Error !");
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        void Close()
        {
            server.Close();
        }
        string message;
        void Receive(object obj)
        {
            Socket client = obj as Socket;
          
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    int id = clientList.IndexOf(client);
                    message = (string)Deseriliaze(data);
                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(Serialize("From " + (id + 1) + " : " + message));
                        }
                    }
                    AddMessage( "From "+ (id+1) + " : " + message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
        void AddMessage(string s)
        {
            lvShow.Items.Add(new ListViewItem() { Text = s });
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        Socket clChoose = null;

        void Send(Socket client)
        {
            
            if ((client != null) && (rtbInput.Text != string.Empty))
            {
                client.Send(Serialize("From Sever : " + rtbInput.Text));
            }
        }

        void Send1(Socket client)
        {

            if ((client != null) && (rtbInput.Text != string.Empty))
            {
                client.Send(Serialize("From Sever : "+rtbInput.Text));
            }
        }

        object Deseriliaze(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

       
        private void btReceive_Click(object sender, EventArgs e)
        {
            if (clChoose == null)
            {
                foreach (Socket item in clientList)
                {
                    Send1(item);
                }
                AddMessage("To " + (cbbClient.Text) + " : " + rtbInput.Text);
            }
            else
            {
                Send(clChoose);
                AddMessage("To " + (cbbClient.Text) + " : " + rtbInput.Text);
            }
            rtbInput.Clear();
        }

        private void cbbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbClient.Text != "All")
            {
                clChoose = clientList.ElementAt(cbbClient.SelectedIndex-1);
            }
            else
            {
                clChoose = null;
            }
        }
    }
}
