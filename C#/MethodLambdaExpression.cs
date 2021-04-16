using System;

namespace AlternateExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };

            // bool makesContact = Array.Exists(spaceRocks, HitGround);
            // below changes the above so that the method of HitGround is defined within the makesContact method
            // this is called a lambda expression
            bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

            // this method can also be written further shorthand.  Removing the type for the second parameter and the parentheses 
            bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");

            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }
        }

        static bool HitGround(string s)
        {
            return s == "meteorite";
        }
    }
}