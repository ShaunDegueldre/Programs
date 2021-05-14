using System;

namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s1 = new Sedan(60);
            Console.WriteLine($"{s1.Speed} is the speed with {s1.Wheels} and a LicensePlate of {s1.LicensePlate}. ");
            s1.SpeedUp();
            Console.WriteLine($"Speed of Sedan 1 has increased to {s1.Speed}.");
            Sedan s2 = new Sedan(70);
            Console.WriteLine($"{s2.Speed} is the speed with {s2.Wheels} and a LicensePlate of {s2.LicensePlate}. ");
            s2.SpeedUp();
            Console.WriteLine($"Speed of Sedan 2 has increased to {s2.Speed}.");
            Truck t1 = new Truck(45, 500);
            Console.WriteLine($"{t1.Speed} is the speed with {t1.Wheels} and a LicensePlate of {t1.LicensePlate}. ");
            t1.SpeedUp();
            Console.WriteLine($"Speed of Truck 1 has increased to {t1.Speed}.");
        }
    }
}