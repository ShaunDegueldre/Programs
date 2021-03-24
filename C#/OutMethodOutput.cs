using System;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageAsString = "102";
            string nameAsString = "Granny";

            int ageAsInt;
            bool outcome;
            // bool outcome is equal to the method Int32.TryParse() trying to parse its input as an integer.  If it can it returns
            // true and sets a specific variable to the new value
            outcome = Int32.TryParse(ageAsString, out ageAsInt);

            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);

            bool outcome2 = Int32.TryParse(nameAsString, out int nameAsInt);

            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);

        }
    }
}
