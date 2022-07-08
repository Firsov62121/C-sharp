using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace UnitTestsForTetris
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] typesCount = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            bool expected = true;
            int n = 0, m = 0;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] typesCount = new int[] { 0, 0, 0, 1, 0, 0, 0 };
            bool expected = false;
            int n = 0, m = 0;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] typesCount = new int[] { 1, 0, 0, 0, 0, 0, 0 };
            bool expected = false;
            int n = 1, m = 3;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] typesCount = new int[] { 1, 0, 0, 0, 0, 0, 0 };
            bool expected = false;
            int n = 5, m = 1;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] typesCount = new int[] { 0, 0, 0, 1, 0, 0, 0 };
            bool expected = false;
            int n = 3, m = 3;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] typesCount = new int[] { 0, 0, 0, 1, 0, 0, 0 };
            bool expected = true;
            int n = 2, m = 2;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] typesCount = new int[] { 0, 0, 0, 2, 0, 0, 0 };
            bool expected = true;
            int n = 4, m = 2;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] typesCount = new int[] { 0, 0, 0, 0, 0, 4, 0 };
            bool expected = false;
            int n = 2, m = 8;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod9()
        {
            int[] typesCount = new int[] { 0, 2, 0, 0, 0, 0, 0 };
            bool expected = true;
            int n = 2, m = 4;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod10()
        {
            int[] typesCount = new int[] { 0, 0, 0, 2, 0, 0, 0 };
            bool expected = true;
            int n = 2, m = 4;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod11()
        {
            int[] typesCount = new int[] { 1, 0, 0, 0, 0, 0, 0 };
            bool expected = true;
            int n = 1, m = 4;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod12()
        {
            int[] typesCount = new int[] { 1, 0, 0, 0, 0, 0, 0 };
            bool expected = true;
            int n = 4, m = 1;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod13()
        {
            int[] typesCount = new int[] { 0, 2, 0, 2, 0, 0, 0 };
            bool expected = true;
            int n = 4, m = 4;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod14()
        {
            int[] typesCount = new int[] { 0, 2, 0, 0, 2, 0, 0 };
            bool expected = true;
            int n = 4, m = 4;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod15()
        {
            int[] typesCount = new int[] { 0, 0, 2, 0, 0, 0, 2 };
            bool expected = true;
            int n = 4, m = 4;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod16()
        {
            int[] typesCount = new int[] { 1, 1, 1, 0, 1, 2, 0 };
            bool expected = true;
            int n = 3, m = 8;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod17()
        {
            int[] typesCount = new int[] { 1, 1, 1, 0, 1, 2, 0 };
            bool expected = true;
            int n = 8, m = 3;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod18()
        {
            int[] typesCount = new int[] { 2, 4, 1, 3, 4, 4, 3 };
            bool expected = true;
            int n = 7, m = 12;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod19()
        {
            int[] typesCount = new int[] { 2, 4, 1, 3, 4, 4, 3 };
            bool expected = true;
            int n = 12, m = 7;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod20()
        {
            int[] typesCount = new int[] { 2, 1, 4, 3, 2, 4, 5 };
            bool expected = true;
            int n = 12, m = 7;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod21()
        {
            int[] typesCount = new int[] { 2, 1, 4, 3, 2, 4, 5 };
            bool expected = true;
            int n = 7, m = 12;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        //count of T is not even  => the sum of black cells doesn't equal to the sum of white cells
        [TestMethod]
        public void TestMethod22()
        {
            int[] typesCount = new int[] { 2, 1, 4, 3, 3, 3, 5 };
            bool expected = false;
            int n = 7, m = 12;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod23()
        {
            int[] typesCount = new int[] { 11, 11, 11, 11, 11, 12, 10};
            bool expected = true;
            int n = 14, m = 22;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }

        [TestMethod]
        public void TestMethod24()
        {
            int[] typesCount = new int[] { 11, 11, 11, 11, 11, 12, 10 };
            bool expected = true;
            int n = 22, m = 14;
            Assert.AreEqual(expected, Tetris.Program.CanPave(n, m, typesCount));
        }
    }
}
