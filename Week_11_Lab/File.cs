using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_Lab
{
    public class File : Document // This class is derived from the email class
    {
        public string pathname { get; set; } 

        public File(string message, string path)
        {
            base.text = message;
            pathname = path;
        }

        public override string ToString()
        {
            Document file1 = new Email();
            return pathname + ": " + file1.ToString();
        }

      
    }

}
