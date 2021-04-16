using System;

namespace AlternateExpressions
{
    class Program
    {
        // Method to be used as second argument
        // Method which is determining if a word is longer than 8 characters
        public static bool IsLong(string word)
        {
            return word.Length > 8;
        }

        static void Main(string[] args)
        {
            // Array to be used as first argument
            // Array of words that describe 
            string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };

            // Call Array.Find(). This is a method that takes an array and a method as an argument.  Returns the first element for which the method returns true 
            // Pass in the array and method as arguments
            string firstLongAdjective = Array.Find(adjectives, IsLong);

            Console.WriteLine($"The first long word is: {firstLongAdjective}.");
        }
    }
}