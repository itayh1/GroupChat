using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Web.Script.Serialization;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GroupChat
{
    public struct Self
    {
        public string name { get; set; }
        public string group { get; set; }
        public string hash { get; set; }
    }
    public class thread_handler
    {
        private Thread threadServer;
        private List<Person> pl;
        private TcpClient t;
        private FrmUsers users;
        private Self self;
        //private byte[] bytes;

        public thread_handler(FrmUsers fu)
        {
            pl = new List<Person>();
            users = fu;
           // t = new Thread(() => msg("hello","it's me"));
           // t.Start();

        }
        public bool createFirstConnection(string adress,string port,
            string type,string enterType,string roomName,string userName)
        {
            int prt;
            if (!int.TryParse(port, out prt))
                return false;
            try { t = new TcpClient(adress, prt); }
            catch { print("couldn't create a connection"); return false; }            
            NetworkStream ns = t.GetStream();
            ns.ReadTimeout = 5000;
            string data =string.Format("{0},{1},{2},{3}",type,enterType,roomName,userName);
            byte[] bytes =System.Text.ASCIIEncoding.ASCII.GetBytes(data);
            ns.Write(bytes, 0, bytes.Length);

            byte[] buffer=new byte[1024];
            Int32 received_bytes;
            try { received_bytes = ns.Read(buffer, 0, buffer.Length); }
            catch { print("recieve error"); return false; }
            string msg = System.Text.ASCIIEncoding.ASCII.GetString(buffer, 0, received_bytes);
            string[] arr = msg.Split(new char[]{','});
            if (arr.Length < 1)
            { print("unknown error"); return false; }
            if (arr[0]=="err")
            {
                switch (arr[1])
                {
                    case "taken": print("room already exist"); break;
                    case "not_exist": print("room not exist"); break;
                    case "exist": print("room already exist"); break;
                    case "invalid": print("request query was invald"); break;
                    default: print("error reason wasn't given"); break;
                }
                return false;
            }
            if (arr[0]=="ok")
            {
                if (enterType == "create") return true;
                else
                {
                    JavaScriptSerializer s = new JavaScriptSerializer();
                    string str = string.Join(",",arr.Skip(1).ToArray<string>());
                    print(str);
                    pl = s.Deserialize<List<Person>>(str);
                    foreach (Person p in pl)
                    {
                        this.users.Add_User(p.name);
                    }                    
                }
                self.name = userName;
                self.group = roomName;
                MD5 md = MD5.Create();
                byte[] hash = md.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(roomName + userName));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                self.hash = sb.ToString();
                return true;
            }
            print("something wrong");
            return false;
        }

        public void main_server_handler(string t1,string t2)
        {
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes("hello");
            byte[] buf = new byte[256];
            //TcpClient t = new TcpClient(new IPEndPoint(new IPAddress(sbyte.Parse("127.0.0.1")), 7878));
            
        }

        public void client_handler()
        {

        }

        public void print(string message) { MessageBox.Show(message); }
    }
}
