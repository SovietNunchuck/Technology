using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTests
    {
        Computer test_computer;

        [TestInitialize]
        public void CreateComputerObject()
        {
            test_computer = new Computer();
        }

        [TestMethod]
        public void PowerOnChangesComputerStatus()
        {
            test_computer.PowerOn();
            Assert.IsTrue(test_computer.PoweredOnStatus);
        }

        [TestMethod]
        public void PowerOffChangesComputerStatus()
        {
            test_computer.PowerOn();
            test_computer.PowerOff();
            Assert.IsFalse(test_computer.PoweredOnStatus);
        }
    }
}
