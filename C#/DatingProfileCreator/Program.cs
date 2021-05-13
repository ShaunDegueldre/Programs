using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

            sam.ViewProfile();
            sam.SetHobbies(new string[] {
                "playing basketball", "swimming", "running" });
            Console.WriteLine(sam.ViewProfile());


        }
    }
}
