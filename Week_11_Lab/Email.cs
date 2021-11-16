using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_Lab
{
    public class Email : Document
    {
        // variables with thier getters and setters
        public string sender { get; set; }
        public string recipient { get; set; }
        public string title { get; set; }
        
        public Email() { }

        public Email(string tester, string send, string reciever, string cover) // gives each variable a value
        {
            base.text = tester;
            sender = send;
            recipient = reciever;
            title = cover;
        }
        public override string ToString() // returns the value of each variable
        {
            return "Sender: " + sender + "\nRecipient: " + recipient + "\nTitle: " + title + "\nBody: " + text;
        }
    }
}
