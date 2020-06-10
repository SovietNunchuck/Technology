using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartPhoneTests
    {
        SmartPhone test_phone;

        [TestInitialize]
        public void CreateSmartPhone()
        {
            test_phone = new SmartPhone();
        }

        [TestMethod]
        public void ContainsApplications()
        {
            Assert.IsTrue(test_phone.Applications.Contains("App Store"));
        }

        [TestMethod]
        public void CanInstallApplications()
        {
            test_phone.Applications.Add("Facebook");
            Assert.IsTrue(test_phone.Applications.Contains("Facebook"));
        }
    }
}
