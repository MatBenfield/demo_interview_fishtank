using FishTankLibrary;
using System;

namespace FishTank
{
    public class Program
    {
        private static void Main(string[] args)
        {
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
