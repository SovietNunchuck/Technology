using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public List<string> Applications { get; set; } = new List<string> { "App Store", "Messages", "Phone", "Calculator"};
        
        public string SMS(string message, string recipient)
        {
            Console.WriteLine($"Are you sure you want to send '{message}' to {recipient}?\n(y/n)");
            string confirmation = Console.ReadLine();
            if (confirmation == "y")
            {
                return "Message sent.";
            }
            else if (confirmation == "n")
            {
                return "Message terminated.";
            }
            else
            {
                return "Invalid input.";
            }
        }
    }
}
