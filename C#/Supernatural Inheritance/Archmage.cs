// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        // Constructor
        public Archmage(string title) : base(title)
        { }

        // Method
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, Title);
        }
    }
}
