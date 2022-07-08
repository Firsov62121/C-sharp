using Microsoft.VisualStudio.TestTools.UnitTesting;
using Perebor3;

namespace UnitTestForPerebor3
{
    [TestClass]
    public class UnitTest1
    {
        //добавь общую сумму - на будущее
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 0;
            int[] a = new int[] { 1, 1 };
            int n = 2;
            Assert.AreEqual(expected, Program.MinDifference(n, a));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int expected = 3;
            int[] a = new int[] { 7, 9, - 8, 3};
            int n = 4;
            Assert.AreEqual(expected, Program.MinDifference(n, a));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int expected = 0;
            int[] a = new int[] { -10, 9, -8, 7 };
            int n = 4;
            Assert.AreEqual(expected, Program.MinDifference(n, a));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int expected = 0;
            int[] a = new int[] { -10, -9, -8, -7 };
            int n = 4;
            Assert.AreEqual(expected, Program.MinDifference(n, a));
        }
        [TestMethod]
        public void TestMethod5()
        {
            int expected = 0;
            int[] a = new int[] { 2, 3, 4, 5 };
            int n = 4;
            Assert.AreEqual(expected, Program.MinDifference(n, a));
        }
        [TestMethod]
        public void TestMethod6()
        {
            int expected = 0;
            int[] a = new int[] { -5, -4, 4, 5, 0, 0, -1, 1};
            int n = 8;
            Assert.AreEqual(expected, Program.MinDifference(n, a));
        }
        [TestMethod]
        public void TestMethod7()
        {
            int expected = 1;
            int[] a = new int[] {1, 2, 3, 4, 5  };
            int n = 5;
            Assert.AreEqual(expected, Program.MinDifference(n, a));
        }
    }
}
