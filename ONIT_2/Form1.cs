using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;

namespace ONIT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ManualResetEvent connectDone = new ManualResetEvent(false);

        
        private void button1_Click(object sender, EventArgs e)
        {
            int BeginPort = Convert.ToInt32(nBeginPort.Value);
            int EndPort = Convert.ToInt32(nEndPort.Value);
            int i;

            progressBar1.Maximum = EndPort - BeginPort + 1;
            progressBar1.Value = 0;
            listView1.Items.Clear();

            IPAddress addr = IPAddress.Parse(tIPAddress.Text);

            for (i = BeginPort; i <= EndPort; i++)
            {
                
                IPEndPoint ep = new IPEndPoint(addr, i);
                Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

               
                IAsyncResult asyncResult = soc.BeginConnect(ep, new AsyncCallback(ConnectCallback), soc);

                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    soc.Close();
                    listView1.Items.Add("Порт " + i.ToString());
                    listView1.Items[i - BeginPort].SubItems.Add("");
                    listView1.Items[i - BeginPort].SubItems.Add("закрыт");
                    listView1.Items[i - BeginPort].BackColor = Color.Bisque;
                    listView1.Refresh();
                    progressBar1.Value += 1;
                }
                else
                {
                    soc.Close();
                    listView1.Items.Add("Порт " + i.ToString());
                    listView1.Items[i - BeginPort].SubItems.Add("открыт");
                    listView1.Items[i - BeginPort].BackColor = Color.LightGreen;
                    progressBar1.Value += 1;
                }
            }
            progressBar1.Value = 0;
        
        }
        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {

            }
        }
    }

}
