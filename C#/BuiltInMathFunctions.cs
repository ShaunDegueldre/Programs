using System;

namespace LowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;
            double numberThree = 6.5;
            double numberFour = 4;


            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

            // Raise numberThree to the numberFour power
            Console.WriteLine(Math.Pow(numberThree, numberFour));

            // Round numberThree up
            Console.WriteLine(Math.Ceiling(numberThree));

            // Find the larger number between numberThree and numberFour
            Console.WriteLine(Math.Max(numberThree, numberFour));

        }
    }
}