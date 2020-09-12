using FishTankLibrary;
using NUnit.Framework;

namespace FishTankTests
{
    [TestFixture]
    public class FishTests
    {
        [TestCase("TestName")]
        public void CreatedFishWithName_Returns_CorrectName(string name)
        {
            var goldfish = new GoldFish(name);

            Assert.AreEqual(goldfish.Name, name);
        }

        [Test]
        public void GoldFishIsATypeOfFish_Returns_True()
        {
            Assert.IsTrue(typeof(GoldFish).IsSubclassOf(typeof(Fish)));
        }

        [Test]
        public void AngelFishIsATypeOfFish_Returns_True()
        {
            Assert.IsTrue(typeof(AngelFish).IsSubclassOf(typeof(Fish)));
        }

        [Test]
        public void BabelFishIsATypeOfFish_Returns_True()
        {
            Assert.IsTrue(typeof(BabelFish).IsSubclassOf(typeof(Fish)));
        }
    }
}
