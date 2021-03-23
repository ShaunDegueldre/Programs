using System;

namespace GettingInput
{   //define class type
    class Program
    {   //main program
        static void Main()
        {
            //line displayed to console to collect data input
            Console.WriteLine("How old are you?");
            //code to collect input from user
            string input = Console.ReadLine();
            //displaying that input to console
            Console.WriteLine($"You are {input} years old!");
        }
    }
}