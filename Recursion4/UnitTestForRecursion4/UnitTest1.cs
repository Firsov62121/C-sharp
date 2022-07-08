using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion4;

namespace UnitTestForRecursion4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.mas = new int[] { 1 };
            Program.n = 1;
            Program.k = 1;
            Assert.AreEqual(Program.isSumEqualK(0, 0), true);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Program.mas = new int[] { 1 };
            Program.n = 1;
            Program.k = 2;
            Assert.AreEqual(Program.isSumEqualK(0, 0),false);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Program.mas = new int[] { 1 };
            Program.n = 1;
            Program.k = 0;
            Assert.AreEqual(Program.isSumEqualK(0, 0), false);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Program.mas = new int[] { 1, 2, 3 };
            Program.n = 3;
            Program.k = 6;
            Assert.AreEqual(Program.isSumEqualK(0, 0), true);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Program.mas = new int[] { 1, 5, 5, 4 };
            Program.n = 4;
            Program.k = 5;
            Assert.AreEqual(Program.isSumEqualK(0, 0), true);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Program.mas = new int[] { 1, 6, 6, 4, 2, 2, 1};
            Program.n = 7;
            Program.k = 6;
            Assert.AreEqual(Program.isSumEqualK(0, 0), true);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Program.mas = new int[] { 1, 2, 3, 4, 5 };
            Program.n = 5;
            Program.k = 15;
            Assert.AreEqual(Program.isSumEqualK(0, 0), true);
        }
    }
}
