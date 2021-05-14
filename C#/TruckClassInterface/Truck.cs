using System;

namespace LearnInterfaces
{
    class Truck : IAutomobile
    {
        public string LicensePlate
        { get; }

        public double Speed
        { get; set; }

        public int Wheels
        { get; }

        public double Weight
        { get; }

        public Truck(double speed, double weight)
        {
            Speed = speed;
            Weight = weight;
            LicensePlate = Tools.GenerateLicensePlate();
            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed = Speed + 5;
        }

        public void SlowDown()
        {
            Speed = Speed - 5;
        }

    }
}