using Microsoft.VisualStudio.TestTools.UnitTesting;
using Date2;

namespace UnitTestForDate2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 51;
            string date1 = "09:10:2019";
            string date2 = "09:10:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int expected = 52;
            string date1 = "12:10:2019";
            string date2 = "12:10:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int expected = 2;
            string date1 = "14:09:2020";
            string date2 = "28:09:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod4()
        {
            int expected = 1;
            string date1 = "14:10:2020";
            string date2 = "27:10:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod5()
        {
            int expected = 1;
            string date1 = "17:02:2020";
            string date2 = "01:03:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod6()
        {
            int expected = 2;
            string date1 = "17:02:2020";
            string date2 = "02:03:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod7()
        {
            int expected = 0;
            string date1 = "25:02:2019";
            string date2 = "03:03:2019";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod8()
        {
            int expected = 1;
            string date1 = "25:02:2019";
            string date2 = "04:03:2019";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod9()
        {
            int expected = 0;
            string date1 = "24:12:2019";
            string date2 = "30:12:2019";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod10()
        {
            int expected = 1;
            string date1 = "23:12:2019";
            string date2 = "30:12:2019";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod11()
        {
            int expected = 2;
            string date1 = "23:12:2019";
            string date2 = "06:01:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
        [TestMethod]
        public void TestMethod12()
        {
            int expected = 1;
            string date1 = "23:12:2019";
            string date2 = "05:01:2020";
            Assert.AreEqual(expected, Program.GetNumOfFullWeeks(date1, date2));
        }
    }
}
