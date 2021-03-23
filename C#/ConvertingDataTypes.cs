using System;

namespace FavoriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");

            // below code does not work as it is reading a string but looking for int
            // int faveNumber = Console.ReadLine();

            // tyring to convert the console.realine to int does not work either
            // int faveNumber = (int)Console.ReadLine();

            //creating int variable the Convert.ToXXXXXXX is how to convert with XXXXXX being data type
            int faveNumber = Convert.ToInt32(Console.ReadLine());

        }
    }
}
