using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrici10;
using System;

namespace UnitTestForMatrici10
{
    [TestClass]
    public class UnitTest1
    { 
        public static bool IsEqual(int[,] a, int[,] b)
        {
            try
            {
                CollectionAssert.AreEqual(a, b);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            Program.n = n;
            Program.a = new int[,]
            {
                {1 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {1 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 3;
            Program.n = n;
            Program.a = new int[,]
            {
                {1, 1, 1 },
                {1, 1, 1 },
                {1, 1, 1 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {1, 1, 1 },
                {1, 1, 1 },
                {1, 1, 1 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 5;
            Program.n = n;
            Program.a = new int[,]
            {
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 },
                {1, 1, 1, 1 ,1 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int n = 3;
            Program.n = n;
            Program.a = new int[,]
            {
                {1, 0, 3 },
                {0, 5, 0 },
                {7, 0, 9 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {1, 0, 3 },
                {0, 5, 0 },
                {7, 0, 9 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int n = 3;
            Program.n = n;
            Program.a = new int[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {1, 4, 3 },
                {8, 5, 2 },
                {7, 6, 9 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }


        [TestMethod]
        public void TestMethod6()
        {
            int n = 5;
            Program.n = n;
            Program.a = new int[,]
            {
                {10, 11, 11, 11, 10 },
                {15, 10, 11, 10, 12 },
                {15, 15, 10, 12, 12 },
                {15, 10, 13, 10, 12 },
                {10, 13, 13, 13, 10 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {10, 15, 15, 15, 10 },
                {13, 10, 15, 10, 11 },
                {13, 13, 10, 11, 11 },
                {13, 10, 12, 10, 11 },
                {10, 12, 12, 12, 10 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod7()
        {
            int n = 5;
            Program.n = n;
            Program.a = new int[,]
            {
                {10, 11, 11, 11, 14 },
                {15, 16, 11, 18, 12 },
                {15, 15, 22, 12, 12 },
                {15, 26, 13, 28, 12 },
                {30, 13, 13, 13, 34 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {10, 15, 15, 15, 14 },
                {13, 16, 15, 18, 11 },
                {13, 13, 22, 11, 11 },
                {13, 26, 12, 28, 11 },
                {30, 12, 12, 12, 34 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod8()
        {
            int n = 5;
            Program.n = n;
            Program.a = new int[,]
            {
                {10, 11, 12, 13, 14 },
                {15, 16, 17, 18, 19 },
                {20, 21, 22, 23, 24 },
                {25, 26, 27, 28, 29 },
                {30, 31, 32, 33, 34 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {10, 25, 20, 15, 14 },
                {31, 16, 21, 18, 11 },
                {32, 27, 22, 17, 12 },
                {33, 26, 23, 28, 13 },
                {30, 29, 24, 19, 34 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod9()
        {
            int n = 7;
            Program.n = n;
            Program.a = new int[,]
            {
                {10, 11, 11, 11, 11, 11, 10 },
                {14, 10, 11, 11, 11, 10, 12 },
                {14, 14, 10, 11, 10, 12, 12 },
                {14, 14, 14, 10, 12, 12, 12 },
                {14, 14, 10, 13, 10, 12, 12 },
                {14, 10, 13, 13, 13, 10, 12 },
                {10, 13, 13, 13, 13, 13, 10 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {10, 14, 14, 14, 14, 14, 10 },
                {13, 10, 14, 14, 14, 10, 11 },
                {13, 13, 10, 14, 10, 11, 11 },
                {13, 13, 13, 10, 11, 11, 11 },
                {13, 13, 10, 12, 10, 11, 11 },
                {13, 10, 12, 12, 12, 10, 11 },
                {10, 12, 12, 12, 12, 12, 10 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod10()
        {
            int n = 7;
            Program.n = n;
            Program.a = new int[,]
            {
                {10, 11, 11, 11, 11, 11, 16 },
                {14, 18, 11, 11, 11, 22, 12 },
                {14, 14, 26, 11, 28, 12, 12 },
                {14, 14, 14, 34, 12, 12, 12 },
                {14, 14, 40, 13, 42, 12, 12 },
                {14, 46, 13, 13, 13, 50, 12 },
                {52, 13, 13, 13, 13, 13, 58 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {10, 14, 14, 14, 14, 14, 16 },
                {13, 18, 14, 14, 14, 22, 11 },
                {13, 13, 26, 14, 28, 11, 11 },
                {13, 13, 13, 34, 11, 11, 11 },
                {13, 13, 40, 12, 42, 11, 11 },
                {13, 46, 12, 12, 12, 50, 11 },
                {52, 12, 12, 12, 12, 12, 58 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod11()
        {
            int n = 7;
            Program.n = n;
            Program.a = new int[,]
            {
                {10, 11, 12, 13, 14, 15, 16 },
                {17, 18, 19, 20, 21, 22, 23 },
                {24, 25, 26, 27, 28, 29, 30 },
                {31, 32, 33, 34, 35, 36, 37 },
                {38, 39, 40, 41, 42, 43, 44 },
                {45, 46, 47, 48, 49, 50, 51 },
                {52, 53, 54, 55, 56, 57, 58 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {10, 45, 38, 31, 24, 17, 16 },
                {53, 18, 39, 32, 25, 22, 11 },
                {54, 47, 26, 33, 28, 19, 12 },
                {55, 48, 41, 34, 27, 20, 13 },
                {56, 49, 40, 35, 42, 21, 14 },
                {57, 46, 43, 36, 29, 50, 15 },
                {52, 51, 44, 37, 30, 23, 58 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }

        [TestMethod]
        public void TestMethod12()
        {
            int n = 9;
            Program.n = n;
            Program.a = new int[,]
            {
                {10, 11, 12, 13, 14, 15, 16, 17, 18 },
                {19, 20, 21, 22, 23, 24, 25, 26, 27 },
                {28, 29, 30, 31, 32, 33, 34, 35, 36 },
                {37, 38, 39, 40, 41, 42, 43, 44, 45 },
                {46, 47, 48, 49, 50, 51, 52, 53, 54 },
                {55, 56, 57, 58, 59, 60, 61, 62, 63 },
                {64, 65, 66, 67, 68, 69, 70, 71, 72 },
                {73, 74, 75, 76, 77, 78, 79, 80, 81 },
                {82, 83, 84, 85, 86, 87, 88, 89, 90 }
            };
            Program.RotateA();
            int[,] expected = new int[,]
            {
                {10, 73, 64, 55, 46, 37, 28, 19, 18 },
                {83, 20, 65, 56, 47, 38, 29, 26, 11 },
                {84, 75, 30, 57, 48, 39, 34, 21, 12 },
                {85, 76, 67, 40, 49, 42, 31, 22, 13 },
                {86, 77, 68, 59, 50, 41, 32, 23, 14 },
                {87, 78, 69, 58, 51, 60, 33, 24, 15 },
                {88, 79, 66, 61, 52, 43, 70, 25, 16 },
                {89, 74, 71, 62, 53, 44, 35, 80, 17 },
                {82, 81, 72, 63, 54, 45, 36, 27, 90 }
            };
            Assert.AreEqual(true, IsEqual(Program.a, expected));
        }
    }
}
