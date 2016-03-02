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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        public void Add_User(string name)
        {
            this.boxList.Items.Add(name);
        }
        public void Remove_User(string name)
        {
            this.boxList.Items.Remove(name);
        }
    }
}
