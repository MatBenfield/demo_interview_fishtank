using System.Data;
using System.Runtime.InteropServices;
using FishTankLibrary;
using NUnit.Framework;

namespace FishTankTests
{
    [TestFixture]
    public class TankTests
    {
        private readonly GoldFish _goldFish;
        private readonly AngelFish _angelFish;
        private readonly BabelFish _babelFish;

        public TankTests()
        {
            _goldFish = new GoldFish("gold");
            _angelFish = new AngelFish("angel");
            _babelFish = new BabelFish("babel");
        }


        [Test]
        public void AddingFishToTank_Returns_CorrectCount()
        {
            var tank = new Tank();
            tank.AddFish(_goldFish);
            Assert.AreEqual(1, tank.Fish.Count);
        }


        [Test]
        public void AddingMultipleFishToTank_Returns_CorrectCount()
        {
            var tank = new Tank();
            tank.AddFish(_goldFish);
            tank.AddFish(_angelFish);
            Assert.AreEqual(2, tank.Fish.Count);
        }

        [Test]
        public void FeedingDifferentTypesOfFish_Returns_CorrectAmount()
        {
            var tank = new Tank();
            tank.AddFish(_goldFish);
            tank.AddFish(_angelFish);
            tank.AddFish(_babelFish);
            const double expectedWeightOfFood = 0.1 + 0.2 + 0.3;
            Assert.AreEqual(expectedWeightOfFood, tank.Feed());
        }

        [Test]
        public void GetNames_Returns_CommaSeparatedStringOfNames()
        {
            var tank = new Tank();
            tank.AddFish(_goldFish);
            tank.AddFish(_angelFish);
            tank.AddFish(_babelFish);
            const string expected = "gold, angel, babel";
            Assert.AreEqual(expected, tank.GetNames());
        }

        [Test]
        public void AddSameNameTwice_Throws_NameTakenException()
        {
            var tank = new Tank();
            tank.AddFish(_goldFish);

            Assert.Throws<DuplicateNameException>(() => tank.AddFish(_goldFish));

        }
    }
}