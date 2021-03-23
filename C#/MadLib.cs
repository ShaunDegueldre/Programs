using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a madlib
            Author: Shaun D
            */


            // Let the user know that the program is starting:
            Console.WriteLine("The Program Has Started");

            // Give the Mad Lib a title:
            string title = "MadLibs For Fun";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter three adjectives hitting enter after each one: ");
            string adjOne = Console.ReadLine();
            string adjTwo = Console.ReadLine();
            string adjThree = Console.ReadLine();

            Console.WriteLine("Enter a Verb: ");
            string verbOne = Console.ReadLine();

            Console.WriteLine("Enter two Nouns hitting enter after each one: ");
            string nounOne = Console.ReadLine();
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Enter one of the following. \n An animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("A food: ");
            string food = Console.ReadLine();
            Console.WriteLine("A fruit: ");
            string fruit = Console.ReadLine();
            Console.WriteLine("A superhero: ");
            string superhero = Console.ReadLine();
            Console.WriteLine("A country: ");
            string country = Console.ReadLine();
            Console.WriteLine("A dessert: ");
            string dessert = Console.ReadLine();
            Console.WriteLine("A year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
