using System;

namespace CaptureOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // String named designer with a value of Anders Hejlsberg
            string designer = "Anders Hejlsberg";
            // Finding the index of the space of the space between words
            int indexOfSpace = designer.IndexOf(" ");
            // Using substring to collect all info after the space in the string and saving to SecondName
            string secondName = designer.Substring(indexOfSpace);
            // Printing value of secondName to console
            Console.WriteLine(secondName);
        }
    }
}
