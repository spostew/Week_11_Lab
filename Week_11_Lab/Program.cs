/*
 * Email: This program will show inheritance and how it works between different classes by using an email as an example
 * Name: Spencer Unitt
 * Module: Lab 11 Week 11
 * 
 * Algorithm: 
 * 1. Create a Document class that contains a string named text, a setter and a Tostring that return text
 * 2. Create a class named email that is derived from the document class and has three strings named sender, recipient, and title
 * 3. Add a Tostring that returns these variables with the text from the Document class
 * 4. Create another class named File that is derived from the Email class with a string named pathfile
 * 5. In the File class, override the tostring to include the pathname into the body of the text
 * 6. In the main method create 4 objects, two of the email and two of the file classes and test them with text and a keyword
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_Lab
{
    class Program
    {
        // This function will text if the keyword is found within the body of the text
        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            // It checks the value of each index and if they match then return true, else return false
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            // Sample strings for the test cases
            string sample1 = "The dogs are barking " + "and playing";
            string sample2 = "The apples were fresh " + " to pick from the trees";
            string keyword = "apples";

            // Objects of the various classes 
            Document email1 = new Email(sample1, "Harry", "Alice", "Child");
            Document email2 = new Email(sample2, "Dudley", "Peter", "lions");

            Document file1 = new File(sample1, "playingDogs.txt");
            Document file2 = new File(sample2, "apple.txt");

            
            // Displays true or false if the keyword is in the email
            Console.WriteLine(ContainsKeyword(email1, keyword));
            Console.WriteLine(ContainsKeyword(email2, keyword));
            Console.WriteLine(ContainsKeyword(file1, keyword));
            Console.WriteLine(ContainsKeyword(file2, keyword));
            
           
            Console.ReadLine();
            
        }
    }
}
