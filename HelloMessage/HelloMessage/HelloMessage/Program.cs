using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString;
            myString = "abc";
            Message myMessage;
            myMessage = new Message(myString);
            myMessage.Print();

            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}
