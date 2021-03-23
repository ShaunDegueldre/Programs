using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();

            if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                Console.WriteLine("Type OPEN or KNOCK: ");
                string doorChoice = Console.ReadLine();
                doorChoice = doorChoice.ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
                    Console.WriteLine("Poor People have it. Rich people need it. If you eat it you will die. What is it?");
                    Console.WriteLine("Type your answer: ");
                    string riddleAnswer = Console.ReadLine();
                    riddleAnswer = riddleAnswer.ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.  The door doesn't open. THE END.");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Choose which key you want to try #1, #2, or #3: ");
                    int keyChoice = Convert.ToInt32(Console.ReadLine());

                    switch (keyChoice)
                    {
                        case 1:
                            Console.WriteLine("You choose key number 1. Lucky Choice!  The door opens and NOTHING is there.  Strange.... THE END>");
                            break;
                        case 2:
                            Console.WriteLine("You choose key number 2.  The door doesn't open. THE END.");
                            break;
                        case 3:
                            Console.WriteLine("You choose key number 3.  Th edoor doesn't open.  THE END.");
                            break;
                        default:
                            Console.WriteLine("that is not a valid choice.  The keys disappear.  THE END.");
                            break;
                    }
                }
            }
            else if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if you dont leave the room!");
            }
        }
    }
}
