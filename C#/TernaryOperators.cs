using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int pepperLength = 4;
            //saving value to message (conditional statement) ?ternaryoperator "if true" :seperator "if false";
            //   (condition) ? true : false
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message);


        }
    }
}
