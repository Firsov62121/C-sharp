using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindTypeOfPoint;

namespace UnitTestForFindTypeOfPoint
{
    [TestClass]
    public class UnitTest1
    {
        public static Point[] points =
        {
            new Point(1, 1),
            new Point(4, -1),
            new Point(4, 2),
            new Point(0, 3),
            new Point(6, 4),
            new Point(6, -6),
            new Point(2, -5),
            new Point(4, -8),
            new Point(-4, -4),
            new Point(4, -4),
            new Point(4, -2),
            new Point(-4, 0),
            new Point(-1, -2),
            new Point(-6, -2),
            new Point(-5, 2),
            new Point(-3, 1)
        };

        public static Point[] points2 =
        {
            new Point(0, -1),
            new Point(0, 2),
            new Point(4, 3),
            new Point(2, 1),
            new Point(2, -1)
        };

        [TestMethod]
        public void TestMethod1()
        {
            bool expected = false;
            Point mainPoint = new Point(3, 0);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool expected = true;
            Point mainPoint = new Point(4, -1);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool expected = false;
            Point mainPoint = new Point(-2, -1);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool expected = true;
            Point mainPoint = new Point(4, -8);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod5()
        {
            bool expected = true;
            Point mainPoint = new Point(3, -7);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod6()
        {
            bool expected = false;
            Point mainPoint = new Point(-2, -1);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod7()
        {
            bool expected = true;
            Point mainPoint = new Point(-3, -1);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod8()
        {
            bool expected = true;
            Point mainPoint = new Point(0, -5);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod9()
        {
            bool expected = false;
            Point mainPoint = new Point(1, -3);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod10()
        {
            bool expected = true;
            Point mainPoint = new Point(4, 1);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod11()
        {
            bool expected = true;
            Point mainPoint = new Point(0, -4);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points));
        }

        [TestMethod]
        public void TestMethod12()
        {
            bool expected = true;
            Point mainPoint = new Point(1, 0);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points2));
        }

        [TestMethod]
        public void TestMethod13()
        {
            bool expected = false;
            Point mainPoint = new Point(-1, -2);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points2));
        }

        [TestMethod]
        public void TestMethod14()
        {
            bool expected = false;
            Point mainPoint = new Point(1, -2);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points2));
        }

        [TestMethod]
        public void TestMethod15()
        {
            bool expected = true;
            Point mainPoint = new Point(2, 1);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points2));
        }

        [TestMethod]
        public void TestMethod16()
        {
            bool expected = false;
            Point mainPoint = new Point(-1, 1);
            Assert.AreEqual(expected, Program.IsContainPoint(mainPoint, points2));
        }
    }
}
