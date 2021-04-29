using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of the alphabet
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            // Asking user to enter the phrase they would like to have encrypted
            Console.Write("Please enter the word or phrase you would like encrypted: ");
            // Saving what they type to a variable called code
            string code = Console.ReadLine();
            // Converting the code to an array
            char[] secretMessage = code.ToCharArray();
            /*  The below code does the same as the line above
            char[] secretMessage = new char[code.Length];

            for (int i = 0; i < code.Length; i++){
              secretMessage[i] = code[i];
            }
            */
            // Printing the array to the console to make sure that it was correct
            foreach (char c in secretMessage)
            {
                Console.WriteLine(c);
            }
            // Getting the length of the array
            int secCodeLength = secretMessage.Length;
            //  Checking the length by printing to console
            Console.WriteLine(secCodeLength);
            //  Creating new array with the same length as the code array
            char[] encryptedMessage = new char[secCodeLength];
            // Checking to make sure the lengths match
            Console.WriteLine(encryptedMessage.Length);
            // Starting a loop to go through the secretmessage code
            for (int i = 0; i < secretMessage.Length; i++)
            {
                // storing char in a variable letter set to the index i of secret message
                char letter = secretMessage[i];
                // Finding the position of the letter within the alphabet array
                int letterPosition = Array.IndexOf(alphabet, letter);
                // Adding 3 to the letter position
                int newLetterPosition = letterPosition + 3;
                // if else to account for the letters which wrap around the alphabet, this could be done with modulo as well
                if (newLetterPosition == 27)
                {
                    newLetterPosition = 1;
                }
                else if (newLetterPosition == 28)
                {
                    newLetterPosition = 2;
                }
                else if (newLetterPosition == 29)
                {
                    newLetterPosition = 3;
                }
                // finding the new position of the encrypted letter
                char letterEncoded = alphabet[newLetterPosition];
                // storing this letter in the new array
                encryptedMessage[i] = letterEncoded;

            }
            // changing the array to a string format
            string encodedString = String.Join("", encryptedMessage);
            // printing the string to the console to display
            Console.WriteLine($"Your endcoded message is: {encodedString}");


        }
    }
}