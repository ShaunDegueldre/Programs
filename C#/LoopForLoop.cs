using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // beginning of for loop (for integer 'I' is equal to one and when integer 'I' is less than 17 add one to integer 'I'
            for (int i = 1; i < 17; i++)
            {
                // while the conditions of the for loop have not been met yet call the CreateTemplate method
                CreateTemplate(i);
            }

        }
        // create template method with an argument for the week number
        static void CreateTemplate(int week)
        {
            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");
        }


    }
}

