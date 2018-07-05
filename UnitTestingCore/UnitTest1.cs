using System;
using MatheOperationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Multiplikation()
        {
            double a = 10, b = 15, c = 2;
            double result = Grundrechenarten.Multiplikation(a, b, ref c);

            Assert.AreEqual(150, result);
        }

        [TestMethod]
        public void Addition()
        {
            double a = 10, b = 15;
            double result = Grundrechenarten.Addition(a, b);

            //Wenn mehrere Asserts vorhanden, dann müssen alle
            //bestehen, damit der Test erfolgreich ist
            Assert.AreEqual(25, result);
            Assert.AreNotEqual(205, result);
        }
    }
}
