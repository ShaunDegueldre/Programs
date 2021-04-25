using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buttonClick = true;
            // beginning of the loop.  Code is stating to do what is in the brackets while what is in the parentheses 
            do
            {
                Console.WriteLine("BLARRRRRRRRR");
            } while (!buttonClick);
            // this is done once the loop has been exited
            Console.WriteLine("Time for a five minute break");
        }
    }
}