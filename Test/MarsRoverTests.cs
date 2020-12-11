using Main.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Enums;

namespace Test
{
    [TestClass]
    public class MarsRoverTests
    {
        Location baseLocation;
        [TestInitialize]
        public void Setup()
        {
            baseLocation = new Location(5, 5);
        }
        [TestMethod]
        public void TestCase1Success()
        {
            Rover rover = new Rover(new Location(1, 2), Directions.N, baseLocation);
            Response roverResult = rover.StartCalculateLocation("LMLMLMLMM");
            Assert.AreEqual(roverResult.Message, "1 3 N");
        }
        [TestMethod]
        public void TestCase2Success()
        {
            Rover rover = new Rover(new Location(3, 3), Directions.E, baseLocation);
            Response roverResult = rover.StartCalculateLocation("MMRMMRMRRM");
            Assert.AreEqual(roverResult.Message, "5 1 E");
        }
        [TestMethod]
        public void TestCase3Error()
        {
            Rover rover = new Rover(new Location(4, 4), Directions.N, baseLocation);
            Response roverResult = rover.StartCalculateLocation("MM");
            Assert.IsFalse(roverResult.Status);
        }
    }
}
