using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class LaptopTests
    {
        Laptop test_laptop;

        [TestInitialize]
        public void CreateLaptopObject()
        {
            test_laptop = new Laptop();
        }

        [TestMethod]
        public void DefaultBatteryLifeIs10Hours()
        {
            test_laptop.TotalBatteryLifeInHours = 10;
        }

        [TestMethod]
        public void LaptopShutsOffIfBatteryRunsOut()
        {
            test_laptop.Use(10);
            Assert.IsFalse(test_laptop.PoweredOnStatus);
        }

        [TestMethod]
        public void BatteryCharges2HoursPerHour()
        {
            test_laptop.Use(9);
            test_laptop.Charge(1);
            Assert.AreEqual(test_laptop.RemainingBatteryLife, 3);
        }
    }
}
