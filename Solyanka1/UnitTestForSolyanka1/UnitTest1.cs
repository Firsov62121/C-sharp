using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solyanka1;

namespace UnitTestForSolyanka1
{
    //решение для n = 10**1000000;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "0";
            Assert.AreEqual(expected, Program.MorsaTue(1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "01";
            Assert.AreEqual(expected, Program.MorsaTue(2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "011";
            Assert.AreEqual(expected, Program.MorsaTue(3));
        }
        [TestMethod]
        public void TestMetho4()
        {
            string expected = "0110";
            Assert.AreEqual(expected, Program.MorsaTue(4));
        }
        [TestMethod]
        public void TestMethod5()
        {
            string expected = "01101";
            Assert.AreEqual(expected, Program.MorsaTue(5));
        }
        [TestMethod]
        public void TestMethod6()
        {
            string expected = "011010";
            Assert.AreEqual(expected, Program.MorsaTue(6));
        }
        [TestMethod]
        public void TestMethod7()
        {
            string expected = "0110100";
            Assert.AreEqual(expected, Program.MorsaTue(7));
        }
        [TestMethod]
        public void TestMethod8()
        {
            string expected = "01101001";
            Assert.AreEqual(expected, Program.MorsaTue(8));
        }
        [TestMethod]
        public void TestMethod9()
        {
            string expected = "011010011";
            Assert.AreEqual(expected, Program.MorsaTue(9));
        }
        [TestMethod]
        public void TestMethod10()
        {
            string expected = "0110100110";
            Assert.AreEqual(expected, Program.MorsaTue(10));
        }
        [TestMethod]
        public void TestMethod11()
        {
            string expected = "01101001100";
            Assert.AreEqual(expected, Program.MorsaTue(11));
        }
        [TestMethod]
        public void TestMethod12()
        {
            string expected = "011010011001";
            Assert.AreEqual(expected, Program.MorsaTue(12));
        }
        [TestMethod]
        public void TestMethod13()
        {
            string expected = "0110100110010";
            Assert.AreEqual(expected, Program.MorsaTue(13));
        }
        [TestMethod]
        public void TestMethod14()
        {
            string expected = "01101001100101";
            Assert.AreEqual(expected, Program.MorsaTue(14));
        }
        [TestMethod]
        public void TestMethod15()
        {
            string expected = "011010011001011";
            Assert.AreEqual(expected, Program.MorsaTue(15));
        }
        [TestMethod]
        public void TestMethod16()
        {
            string expected = "0110100110010110";
            Assert.AreEqual(expected, Program.MorsaTue(16));
        }
        [TestMethod]
        public void TestMethod24()
        {
            string expected = "011010011001011010010110";
            Assert.AreEqual(expected, Program.MorsaTue(24));
        }
        [TestMethod]
        public void TestMethod25()
        {
            string expected = "0110100110010110100101100";
            Assert.AreEqual(expected, Program.MorsaTue(25));
        }
        [TestMethod]
        public void TestMethod26()
        {
            string expected = "01101001100101101001011001";
            Assert.AreEqual(expected, Program.MorsaTue(26));
        }
        [TestMethod]
        public void TestMethod27()
        {
            string expected = "011010011001011010010110011";
            Assert.AreEqual(expected, Program.MorsaTue(27));
        }
        [TestMethod]
        public void TestMethod28()
        {
            string expected = "0110100110010110100101100110";
            Assert.AreEqual(expected, Program.MorsaTue(28));
        }
        [TestMethod]
        public void TestMethod29()
        {
            string expected = "01101001100101101001011001101";
            Assert.AreEqual(expected, Program.MorsaTue(29));
        }
        [TestMethod]
        public void TestMethod30()
        {
            string expected = "011010011001011010010110011010";
            Assert.AreEqual(expected, Program.MorsaTue(30));
        }
        [TestMethod]
        public void TestMethod31()
        {
            string expected = "0110100110010110100101100110100";
            Assert.AreEqual(expected, Program.MorsaTue(31));
        }
        [TestMethod]
        public void TestMethod32()
        {
            string expected = "01101001100101101001011001101001";
            Assert.AreEqual(expected, Program.MorsaTue(32));
        }


        [TestMethod]
        public void TestMethod33()
        {
            uint expected = 1737517376;
            Assert.AreEqual(expected, Program.HashFromMorsaTue(1000000));
        }
    }
}
