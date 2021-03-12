using NUnit.Framework;

namespace Home_project.Tests
{
    public class PeremensTests
    {
        [TestCase(5, 13, 24)]
        [TestCase(8, 2, -7)]
        [TestCase(2, 10, 13)]
        public void DZ_1_1_Tests(int a, int b, int expected)
        {
            int actual = Peremens.DZ_1_1(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 0)]
        public void DZ_1_1_TestsNegativ(int a, int b)
        {
            try
            {
                Peremens.DZ_1_1(a, b);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(5, 13, new int[2] { 13, 5 })]
        [TestCase(8, 2, new int[2] { 2, 8 })]
        [TestCase(2, 10, new int[2] { 10, 2 })]
        public void DZ_1_2_Tests(int a, int b, int[] expected)
        {
            int[] actual = Peremens.DZ_1_2(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 8, "0,7")]
        [TestCase(22, 10, "2,2")]
        [TestCase(11, 9, "1,2")]
        public void DZ_1_3_Tests(int a, int b, string expected)
        {
            string actual = Peremens.DZ_1_3(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 60, 28)]
        [TestCase(8, 4, 2, 0)]
        [TestCase(22, 11, 55, 2)]
        public void DZ_1_4_Tests(int number1, int number2, int number3, int expected)
        {
            int actual = Peremens.DZ_1_4(number1, number2, number3);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 2, 5, "Для первой координаты:4=-1*3+7;  Для второй координаты:5=-1*2+7;")]
        [TestCase(8, 9, 1, 3, "Для первой координаты:9=0*8+9;  Для второй координаты:3=0*1+3;")]
        [TestCase(11, 24, 16, 3, "Для первой координаты:24=-4*11+68;  Для второй координаты:3=-4*16+67;")]
        public void DZ_1_5_Tests(int X1, int Y1, int X2, int Y2, string expected)
        {
            string actual = Peremens.DZ_1_5(X1,Y1,X2,Y2);
            Assert.AreEqual(expected, actual);
        }
    }
}
