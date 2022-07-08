using Microsoft.VisualStudio.TestTools.UnitTesting;
using Files2;

namespace UnitTestForFiles2
{
    [TestClass]
    public class UnitTest1
    {
        static string fileNameToRead = @"D:\основное\учеба\программирование Чернышев\задания\Files2\FileForFiles2.txt";
        static string fileNameToWrite = @"D:\основное\учеба\программирование Чернышев\задания\Files2\FileFromFiles2.txt";
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "taracantaracan";
            Assert.AreEqual(expected, Program.Replace(fileNameToRead, fileNameToWrite, "s", "t"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "paracanparacan";
            Assert.AreEqual(expected, Program.Replace(fileNameToRead, fileNameToWrite, "t", "p"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "zeeracanzeeracan";
            Assert.AreEqual(expected, Program.Replace(fileNameToRead, fileNameToWrite, "ta", "zee"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            string expected = "proigralproigral";
            Assert.AreEqual(expected, Program.Replace(fileNameToRead, fileNameToWrite, "taracan", "proigral"));
        }
        [TestMethod]
        public void TestMethod5()
        {
            string expected = "fr";
            Assert.AreEqual(expected, Program.Replace(fileNameToRead, fileNameToWrite, "taracantaracan", "fr"));
        }
    }
}
