using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opening for quiz
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Array of questions
            string[] questions = { "Most of the water on earth is fresh", "The moon revolves around the earth", "Potatoes are a vegetables", "Our solar system has nine plants", "The United States has had 47 presidents", "Washington D.C. is considered a state" };
            // Array of answers to questions
            bool[] answers = { false, true, true, false, false, false };
            // Empty array of responses which is equal to number of questions
            bool[] responses = new bool[questions.Length];
            // keeping track of number of questions asked
            int askingIndex = 0;
            // start of for loop to ask questions for quiz
            foreach (string q in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine("\n");
                Console.WriteLine(q);
                Console.WriteLine("true or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                // while loop to ensure that a true or false answer was provided
                while (isBool == false)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(q);
                    Console.WriteLine("true or false?");
                    Console.WriteLine("Please respond with true of false");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                // converting input string to bool
                bool ansbool = bool.Parse(input);
                // logging responses to the responses array
                responses[askingIndex] = ansbool;
                // incrementing the askingIndex by 1
                askingIndex++;
            }
            // Showing the student the answers they have logged
            Console.WriteLine("\nYour responses are as follows: \n");
            foreach (bool a in responses)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");
            // variables created to keep track of question logging and correct answers
            int scoringIndex = 0;
            int score = 0;
            // for loop to go through responses array
            foreach (bool a in responses)
            {
                // printing to console the answers provided and correct answer
                Console.WriteLine($"Input: {a} Correct Answer: {answers[scoringIndex]}");
                // if else to log score
                if (a == answers[scoringIndex])
                {
                    score++;
                }
                // displaying current score after each answer is logged
                Console.WriteLine($"Your current correct answers is {score} out of {scoringIndex + 1}\n");
                scoringIndex++;

            }
            // converting int to double and finding the percentage grade
            double right = Convert.ToDouble(score);
            double total = Convert.ToDouble(scoringIndex);
            double final = right / total;
            final = final * 100;
            final = Math.Round(final, 2);

            // displaying the letter grade score for the test
            Console.WriteLine($"The final score for this test is {final}");

            if (final < 60)
            {
                Console.WriteLine("You have failed");
            }
            else if (final < 70 && final >= 60)
            {
                Console.WriteLine("You have received a D");
            }
            else if (final < 80 && final >= 70)
            {
                Console.WriteLine("You have received a C");
            }
            else if (final < 90 && final >= 80)
            {
                Console.WriteLine("You have received a B");
            }
            else if (final <= 100 && final >= 90)
            {
                Console.WriteLine("You have received a A");
            }
        }
    }
}