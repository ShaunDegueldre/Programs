using System;

namespace BasicClasses
{
    // creation of the class Forst
    class Forest
    {
        // Adding four fields to the forest class
        public int trees;
        public int age;


        public string name;
        // adding properties for name field. Use name but capitalize it
        public string Name
        {
            // getter to access the name property
            get { return name; }
            // setter to provide property limits
            set { name = value; }
        }
        /* Using automatic property line 13 through line 21 can be written as
         * public string Name
         * { get; set; }
         */

        // making the set method private so that it can not be adjusted in main
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        // Constructor method to create a new object within the forest class without having to list each value one by one
        public Forest(string name, string biome, int Trees)
        {
            Name = name;
            Biome = biome;
            Age = 0;
        }

        public int Trees
        {
            get { return trees; }
            // creating a limit that if the amount of trees is less than 0 than it can only be 0 otherwise place value set
            set
            {
                if (value < 0) { trees = 0; }
                else { trees = value; }
            }
        }
        // Making a private memeber will only allow access by code in the same class
        private string biome;
        public string Biome
        {
            get { return biome; }
            // creating limits to the name of the value for the biome, if that is not used then it will be listed as unknown
            set
            {
                if (value == "Tropical" || value == "Temperate" || value == "Boreal") { biome = value; }
                else { biome = "Unknown"; }
            }
        }
        // creates a method for called burn which takes away 20 trees and increases age by 1 then returns trees
        public int Burn()
        {
            Trees = Trees - 20;
            Age = Age + 1;
            return Trees;
        }

    }

}

