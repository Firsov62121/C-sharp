using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpainTranslate2;

namespace UnitTestForSpainTranslate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "cien";
            int n = 100;
            Program.p = 0;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "cien";
            int n = 100;
            Program.p = 1;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "un";
            int n = 1;
            Program.p = 1;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string expected = "una";
            int n = 1;
            Program.p = 0;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string expected = "un";
            int n = 1;
            Program.p = 1;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string expected = "setecientos un";
            int n = 701;
            Program.p = 1;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string expected = "seiscientas una";
            int n = 601;
            Program.p = 0;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string expected = "quinientos vientiun";
            int n = 521;
            Program.p = 1;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string expected = "cuatrocientas vientiuna";
            int n = 421;
            Program.p = 0;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string expected = "trescientos treinta y un";
            int n = 331;
            Program.p = 1;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string expected = "doscientas treinta y una";
            int n = 231;
            Program.p = 0;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string expected = "novecientas noventa y nueve milliones, " +
                "ochocientas ochenta y ocho mil, setecientas setenta y siete";
            int n = 999888777;
            Program.p = 0;
            Assert.AreEqual(Program.Spain10_9(n), expected);
        }
    }
}
