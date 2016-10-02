using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Demo
{
    // Mock object for ILogger

    public class TestLogger : ILogger
    {
        public bool Logged { get; set; }

        public void Log(string message)
        {
            Logged = true;
        }
    }

    // SubscriptionSystem
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SubscribeWorks()
        {
            var system = new SubscriptionSystem(new TestLogger());
            system.Subscribe(new User { Username = "Niki" });
            Assert.AreEqual(1,system.Users.Count);
        }

        [TestMethod]
        public void Users_ShouldBeCharged()
        {
            var system = new SubscriptionSystem(new TestLogger());
            var user1 = new User {Balance=500};
            var user2 = new User();
            system.Users.Add(user1);
            system.Users.Add(user2);
            system.Charge(500);
            Assert.AreEqual(1000, user1.Balance);
            Assert.AreEqual(500, user2.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
            public void SystemCharge_ShouldNotAcceptNegativeValues()
        {
            var system = new SubscriptionSystem(new TestLogger());
            system.Charge(-500);
        }

        [TestMethod]
        public void SystemCharge_ShouldLog()
        {
            var logger = new TestLogger();   // We create variable from type TestLogger
            logger.Logged = false;           // Just in case we set Logged to false
            var system = new SubscriptionSystem(logger); // in the constructor we will give the variable
            system.Charge(100);
            Assert.IsTrue(logger.Logged);
        }
    }
}
