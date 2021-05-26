// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        // Constructor
        public Mage(string title) : base(title)
        { }

        // Method
        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
}
