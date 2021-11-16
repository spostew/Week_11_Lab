using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_Lab
{
    public class Document
    {
        // string variable to store the body of the text
        public string text;

        public Document() { } // default constructor

        public Document(string tester)
        {
            setText(tester); // sets the text
        }
        void setText(string text) { this.text = text; }
        public override string ToString() // returns the variable
        {
            return text;
        }
    }
}
