using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting1;

namespace BasicMathsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            BasicMaths basicMath = new BasicMaths();
            double result = basicMath.Add(10, 10);
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void TestSubstractMethod()
        {
            BasicMaths basicMath = new BasicMaths();
            double result = basicMath.Substract(10,10);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestDivideMethod()
        {
            BasicMaths basicMath = new BasicMaths();
            double result = basicMath.Divide(10, 5);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            BasicMaths basicMath = new BasicMaths();
            double result = basicMath.Multiply(10, 10);
            Assert.AreEqual(result, 100);
        }

        [TestMethod]
        public void TestIPsMethod()
        {
            BasicMaths basicMaths = new BasicMaths();
            double result = basicMaths.GetNumberOfIPs(255, 4);
            Assert.AreEqual(result, 4228250625);
        }
    }
}
