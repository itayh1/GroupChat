using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GroupChat
{
    public partial class Form1 : Form
    {
        private FrmUsers frmUsers = new FrmUsers();
        private thread_handler th;
        private bool isConnected;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.LocationChanged += new EventHandler(Form1_LocationChanged);
            th = new thread_handler(frmUsers);
            isConnected = false;          
        }

        void Form1_LocationChanged(object sender, EventArgs e)
        {
            frmUsers.Location =  new Point(this.Location.X + this.Size.Width, this.Location.Y );
            frmUsers.Height = this.Height;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            frmUsers.Show();
            
            //MessageBox.Show(sender.GetType().ToString());           
            //throw new NotImplementedException();
        }

        private void btnConnent_Click(object sender, EventArgs e)
        {
            if (this.isConnected==false)
            {
                string type = "";
                string joinOrCreate = "";
                string roomName = txtRoom.Text;
                string userName = txtName.Text;
                if (rdVoice.Checked == true) type = "voice";
                switch (comType.SelectedIndex)
                {
                    case 0: joinOrCreate = "create"; break;
                    case 1: joinOrCreate = "join"; break;
                    default: MessageBox.Show("You didn't choose wheater join or create a room");
                        return;
                }
                if (roomName == "" || userName == "") { MessageBox.Show("Empty Username or Groupname"); return; }
                bool succes = th.createFirstConnection("127.0.0.1", "8080", type, joinOrCreate, roomName, userName);
                if (succes)
                {
                    MessageBox.Show("succeed to create first connection");
                    lblStat.Text = "connected";
                    this.isConnected = true;
                    this.btnConnent.Text = "disconnect";
                }
                else
                {

                }
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("kushi" + Environment.NewLine);
            frmUsers.Add_User("hello user");
            richTextBox1.ScrollToCaret();
        }
    }
}
