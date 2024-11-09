using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc=new Calculator();
            int act= calc.addition(2,2);
            Assert.AreEqual(4, act);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var calc = new Calculator();
            int act = calc.substraction(4, 2);
            Assert.AreEqual(2, act);
        }
    }
}