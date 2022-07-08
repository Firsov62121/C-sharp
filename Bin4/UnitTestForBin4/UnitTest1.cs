using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bin4;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Linq;

namespace UnitTestForBin4
{
    [TestClass]
    public class UnitTest1
    {
        /*
        static bool Compare(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
        */
        //Collections.Assert
        [TestMethod]
        public void TestMethod1()
        {
            int[] expected = new int[] { 2, 4, 5, 8, 9 };
            int n = 10;
            Assert.AreEqual(true, expected.SequenceEqual(Program.GetAllGoodNums(n)));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] expected = new int[] { };
            int n = 2;
            Assert.AreEqual(true, expected.SequenceEqual(Program.GetAllGoodNums(n)));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] expected = new int[] { 2 };
            int n = 4;
            Assert.AreEqual(true, expected.SequenceEqual(Program.GetAllGoodNums(n)));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] expected = new int[] { 2, 4 };
            int n = 5;
            Assert.AreEqual(true, expected.SequenceEqual(Program.GetAllGoodNums(n)));
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] expected = new int[] { 2, 4, 5, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 26};
            int n = 32;
            Assert.AreEqual(true, expected.SequenceEqual(Program.GetAllGoodNums(n)));
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] expected = new int[] { 2, 4, 5, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 26, 32};
            int n = 33;
            Assert.AreEqual(true, expected.SequenceEqual(Program.GetAllGoodNums(n)));
        }
    }
}
