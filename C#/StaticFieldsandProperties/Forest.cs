using System;

namespace StaticMembers
{
    class Forest
    {
        // FIELDS

        public int age;
        private string biome;
        // creation of a private static field called forestsCreated
        private static int forestsCreated;
        // creation of private static field called treeFacts
        private static string treeFacts;

        // CONSTRUCTORS

        // A static construcstion named Forest
        static Forest()
        {
            // Setting treeFacts field to the string listed
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
            // Set ForestsCreated to 0
            ForestsCreated = 0;
        }

        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
            // Each time a class of Forest is created it will increment ForestsCreated by 1
            ForestsCreated = ForestsCreated + 1;
        }

        public Forest(string name) : this(name, "Unknown")
        { }

        // PROPERTIES

        // A public static property called TreeFacts which will have a getter function but no setter
        public static string TreeFacts
        {
            get { return treeFacts; }
        }
        // A public static property called ForestsCreated which will return value with get and keep the set private 
        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        // METHODS

        // A public static method named PrintTreeFacts() which will write the value of TreeFacts to the console.
        public static void PrintTreeFacts()
        {
            Console.WriteLine(TreeFacts);
        }

        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

    }

}