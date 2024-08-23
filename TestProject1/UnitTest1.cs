using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program c = new Program();
            string resp = c.test("a");

            Assert.AreEqual("test17", resp);
        }
    }
}
