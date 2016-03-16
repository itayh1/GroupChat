using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        internal class person
        {
            public string name { get; set; }
            public string ip { get; set; }
            public override string ToString()
            {
                return string.Format("name={0} ,ip={1}", name, ip);
            }
        }

        static void Main(string[] args)
        {
            //List<person> l = new List<person>();
            //person[] parr = new person[2];
            //person p = new person() { name = "itay", ip = "123" };
            //person p1 = new person() { name = "moshe", ip = "456" };
            //parr[0] = p;
            //parr[1] = p1;
            //l.Add(p);
            //l.Add(p1);
            JavaScriptSerializer s = new JavaScriptSerializer();
            //string st = s.Serialize(l);
            //Console.WriteLine(st);

            StreamReader sr = new StreamReader("F:\\project\\test2.txt");
            string str = sr.ReadToEnd();

            List<person> list = s.Deserialize<List<person>>(str);
            foreach (person item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
     }
}
