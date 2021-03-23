using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Please enter your total value of coins: ");
            double totalCoin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{totalCoin} is equal to ...");
            // setting amount for what each coin is equal to
            double goldCoin = 10;
            double silverCoin = 5;
            // figuring the total number of gold coins and the leftover   
            double goldCoins = totalCoin / goldCoin;
            double gCoin = Math.Floor(goldCoins);
            double leftover = totalCoin % goldCoin;
            // finding the total number of silver coins and the leftover
            double silverCoins = leftover / silverCoin;
            double sCoin = Math.Floor(silverCoins);
            double finalLeftover = leftover % silverCoin;
            double totalpieces = gCoin + sCoin + finalLeftover;
            // printing the total amounts to the console
            Console.WriteLine($"{gCoin} coin(s) of gold, {sCoin} coin(s) of silver {finalLeftover} coin(s) of bronze, using a total number of {totalpieces} coins");
        }
    }
}
