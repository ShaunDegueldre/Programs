using System;

namespace PasswordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;

            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");

            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");







            // User Name
            string name = "Farhad Hesam Abbasi";

            // Get first letter
            int charPosition = name.IndexOf("F");
            char firstLetter = name[charPosition];

            // Get last name
            int namePosition = name.IndexOf("Abbasi");
            string lastName = name.Substring(namePosition);

            // Print results F. Abbasi
            Console.WriteLine(firstLetter + ". " + lastName);







            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine(cameraDirections + " " + sceneDescription);


        }
    }
}
