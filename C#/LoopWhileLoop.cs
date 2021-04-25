using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int emails = 20;
            // beginning of while loop giving a detail of what is required to be done while condition has not been met
            while (emails > 0)
            {
                // what occurs each time an iteration of the loop occurs
                Console.WriteLine("Deleting 1 Email");
                emails = emails - 1;
            }
            // what happens once the loop has been exited
            Console.WriteLine("INBOX ZERO ACHIEVED!");
        }
    }
}