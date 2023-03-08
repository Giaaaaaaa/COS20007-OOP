using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HelloMessage
{
    internal class Message
    {
        private string text;
        public Message(string txt) 
        {
            text = txt;
        }
        public void Print()
        {
            Console.WriteLine(text);
        }
    }
}
