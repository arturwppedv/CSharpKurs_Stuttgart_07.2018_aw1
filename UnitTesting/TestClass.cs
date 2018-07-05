using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatheOperationen;

namespace UnitTesting
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void Multiplikation()
        {
            double a = 10, b = 15, c = 2;
            double result = Grundrechenarten.Multiplikation(a, b, ref c);

            Assert.AreEqual(300, result);
        }
    }
}
