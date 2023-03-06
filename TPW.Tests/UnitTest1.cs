namespace TPW.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestClass fib = new TestClass();
            int output = fib.Fib(10);
            Assert.AreEqual(output, 55);
        }
    }
}