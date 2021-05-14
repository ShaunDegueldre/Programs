using System;

namespace LearnInterfaces
{
    class Sedan : IAutomobile
    {
        public string LicensePlate
        { get; protected set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

    }
}