using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GroupChat
{
    public partial class Form1 : Form
    {
        private FrmUsers frmUsers = new FrmUsers();
        Thread t;
        thread_handler th = new thread_handler();
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.LocationChanged += new EventHandler(Form1_LocationChanged);           
        }

        void Form1_LocationChanged(object sender, EventArgs e)
        {
            frmUsers.Location =  new Point(this.Location.X + this.Size.Width, this.Location.Y );
            frmUsers.Height = this.Height;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());           
            frmUsers.Show();
            //throw new NotImplementedException();
        }

        private void btnConnent_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("kushi" + Environment.NewLine);
            frmUsers.Add_User("hello user");
            richTextBox1.ScrollToCaret();
            t = new Thread(new ThreadStart(th.DS));
            t.Start();
        }
    }
}
