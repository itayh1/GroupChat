using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupChat
{
    public class Person
    {
        public string name { get; set; }
        public string ip { get; set; }

        public override string ToString()
        {
            return string.Format("name: {0},ip: {1}", name, ip);
        }
    }
}
