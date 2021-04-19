using System;

namespace BuildingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // type of array [] name of array
            string[] summerStrut;
            // name of array adding type then list of variables added
            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            // type of array, name of array, new variables that are set to the array
            int[] ratings = new int[] { 5, 4, 4, 3, 3, 5, 5, 4 };

            // USE OF .LENGTH TO DETERMINE THE LENGTH OF ARRAY
            // creation of int variable with the amount of items in summerStrut array
            int summerStrutLength = summerStrut.Length;
            // printing to console the number in the summerStrut array
            Console.WriteLine(summerStrutLength);
            // determining the amount of itmes in array and printing the appropriate message
            if (summerStrut.Length == 8)
            {
                Console.WriteLine("summerStrut Playlist is ready to go!");
            }
            else if (summerStrut.Length > 8)
            {
                Console.WriteLine("Too many songs!");
            }
            else
            {
                Console.WriteLine("Add more songs!");
            }

            // ACCESSING ARRAY ITEMS
            // assigning string numbertwo the second item in the summerStrut Array
            string numbertwo = summerStrut[1];
            // assinging ratingtwo the second item in the ratings Array
            int ratingtwo = ratings[1];
            // printing to console the second song in the array with the second rating
            Console.WriteLine($"You rated the song, {numbertwo} {ratingtwo} stars");

            // Change the last song in the array to I Like It
            summerStrut[7] = "I Like It";
            // Change the rating of the last song as well
            ratings[7] = 2;

            // use IndexOf to find the location of the first song with a value of 3 rating
            int firstthreestar = Array.IndexOf(ratings, 3);
            // checking to see if this pulled the right location from array
            Console.WriteLine(firstthreestar);
            // printing to console the song number and the rating
            Console.WriteLine($"Song number {firstthreestar + 1} is rated three stars");

            // using Find to locate the first variable with more than ten character in the array of summerStrut
            string firsttenchar = Array.Find(summerStrut, tenchar => tenchar.Length > 10);
            // chekcing to see if this pulled the right variable from the array
            Console.WriteLine(firsttenchar);
            // printing to console the first ten character song in the array
            Console.WriteLine($"The first song that has more than 10 characters in the title is {firsttenchar}.");

            // sorting the array summerStrut in aphabetical order
            Array.Sort(summerStrut);
            // checking the first value in the array
            Console.WriteLine(summerStrut[0]);
            // checking the 8th value in the array
            Console.WriteLine(summerStrut[7]);

            // create summerStrutCopy array a string array with 8 values
            string[] summerStrutCopy = new string[8];
            // copy array summerStrut to summerStrutCopy 8 values
            Array.Copy(summerStrut, summerStrutCopy, 8);
            // print to console the 1st variable in array summerStrutCopy to verify
            Console.WriteLine(summerStrutCopy[0]);

            // reverse the summerStrut array
            Array.Reverse(summerStrut);
            // print to console the 1st variable in summerStrut array to verify
            Console.WriteLine(summerStrut[0]);
            // print to console the last variable in summerStrut array to verify
            Console.WriteLine(summerStrut[7]);

            // clear the ratings array and turn every variable to 0
            Array.Clear(ratings, 0, ratings.Length);
            // check to see if 0
            Console.WriteLine(ratings[0]);


        }
    }
}

        }
    }
}
