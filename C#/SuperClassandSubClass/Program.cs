using System;

namespace LearnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine(s.Describe());
            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());
            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe());



        }
    }
}