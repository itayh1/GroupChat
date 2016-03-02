using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GroupChat
{
    static class Program
    {
        public static  Form1 mainF;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainF=new Form1();
            Application.Run(mainF);
        }
    }
}
