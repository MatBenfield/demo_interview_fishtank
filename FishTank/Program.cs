using FishTankLibrary;
using System;

namespace FishTank
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("I Need a new C# Class library (any .net version) to help me manage my fish tank");
            Console.WriteLine("Don't worry about the UI: I will build that");
            Console.WriteLine("The library should satisfy the following user stories and demonstrate your design, coding and testing abilities");
            Console.WriteLine("");
            Console.WriteLine("Here are the user stories:");
            Console.WriteLine(" 1. A user should be able to add 3 types of fish to the tank (Gold, Angel, and Babel) and name them");
            Console.WriteLine(" 2. A user should be able to see how much food to put in the tank with a Tank.Feed() method. This should return the weight in grams of the total required fish food.");
            Console.WriteLine("");
            Console.WriteLine("0.1g for each Gold, 0.2g for each Angel, and 0.3g for each Babel fish");
            Console.WriteLine("Ensure the design allows me to add more types of fish in the future without having to change the tank class");
            Console.WriteLine("");

            var tank = new Tank();
            var goldFish = new GoldFish("Goldie");
            var angelFish = new AngelFish("Angelica");
            var babelFish = new BabelFish("Ryan");

            tank.AddFish(goldFish);
            WriteCurrentStatus(tank);

            tank.AddFish(angelFish);
            WriteCurrentStatus(tank);

            tank.AddFish(babelFish);
            WriteCurrentStatus(tank);

            Console.Read();

        }

        private static void WriteCurrentStatus(Tank tank)
        {
            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine($"You have {tank.Count()} fish in total ({tank.GetNames()})");
            Console.WriteLine($"with {tank.Feed()} grams of food required to feed all your fish!");
        }
    }
}
