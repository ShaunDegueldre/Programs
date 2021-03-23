using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            // creation of variables; used bool to help with tools.contains coming back as true or false
            double minLength = 8;
            bool uppercase;
            bool lowercase;
            bool digits;
            bool specialChars;
            // ask user to put in a password
            Console.WriteLine("Please enter a Password: ");
            // storing the password in variable password
            string password = Console.ReadLine();
            // set score equal to 0
            double score = 0;
            //  checking password length and adding point to score if it meets requirements
            if (password.Length >= minLength)
            {
                score++;
            }
            //  checking password for digits and adding point to score if it meets requirements
            digits = Tools.Contains(password, "1234567890");
            if (digits == true)
            {
                score++;
            }
            //  checking password for special characters and adding point to score if it meets requirements
            specialChars = Tools.Contains(password, "!@#$%^&*?:<>+");
            if (specialChars == true)
            {
                score++;
            }
            //  checking password for uppercase letters and adding point to score if it meets requirements
            uppercase = Tools.Contains(password, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            if (uppercase == true)
            {
                score++;
            }
            //  checking password for lowercase letters and adding point to score if it meets requirements
            lowercase = Tools.Contains(password, "abcdefghijklmnopqrstuvwxyz");
            if (lowercase == true)
            {
                score++;
            }

            //  printing out the score to the console
            Console.WriteLine(score);

            //  switch statement printing the quality of password determined by the score
            switch (score)
            {
                case 1:
                    Console.WriteLine("Your password is weak");
                    break;
                case 2:
                    Console.WriteLine("Your password is medium strength");
                    break;
                case 3:
                    Console.WriteLine("Your password is strong");
                    break;
                case 4:
                    Console.WriteLine("You have a very strong password");
                    break;
                case 5:
                    Console.WriteLine("You meet all requirements for a optimal password");
                    break;
                default:
                    Console.WriteLine("Please rerun program");
                    break;
            }
        }
    }
}
