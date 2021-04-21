using Domain;
using NUnit.Framework;
using System;

namespace Tests
{
    public class PersonsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DirectorTotalPay()
        {
            Director director = new Director("Петя Масло", 23);
            Assert.IsTrue(director.TotalPay == 65714);
        }

        [Test]
        public void AccountantTotalPay()
        {
            Accountant accountant = new Accountant("Раиса Измайлова", 22);
            Assert.IsTrue(accountant.TotalPay == 47143);
        }
        [Test]
        public void SecurityTotalPay()
        {
            Security security = new Security("Аут", 18);
            Assert.IsTrue(security.TotalPay == 21429);
        }
        [Test]
        public void ManagerTotalPay()
        {
            Manager manager = new Manager("Ольга А", 20);
            Assert.IsTrue(manager.TotalPay == 38095);
        }
    }
}