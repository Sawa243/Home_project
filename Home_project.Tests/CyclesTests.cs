using NUnit.Framework;

namespace Home_project.Tests
{
    class CyclesTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 27)]
        [TestCase(5, 2, 25)]
        public void DZ_3_1_Tests(int a, int b, int expected)
        {
            int actual = Cycles.DZ_3_1(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 0)]
        public void DZ_3_1_TestsNegativ(int a, int b)
        {
            try
            {
                Cycles.DZ_3_1(a, b);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }

        }

        [TestCase(300, " 0 300 600 900")]
        [TestCase(400, " 0 400 800")]
        [TestCase(250, " 0 250 500 750")]
        public void DZ_3_2_Tests(int chislo, string expected)
        {
            string actual = Cycles.DZ_3_2(chislo);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(50, 28 )]
        [TestCase(35, 15)]
        [TestCase(25, 10)]
        public void DZ_3_3_Tests(int a, int expected)
        {
            int actual = Cycles.DZ_3_3(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(50, 25)]
        [TestCase(35, 7)]
        [TestCase(84, 42)]
        public void DZ_3_4_Tests(int a, int expected)
        {
            int actual = Cycles.DZ_3_4(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(50, 25, 154)]
        [TestCase(35, 7, 63)]
        [TestCase(84, 42, 315)]
        public void DZ_3_5_Tests(int a, int b, int expected)
        {
            int actual = Cycles.DZ_3_5(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 25, 54, "N - ое число ряда: 212")]
        [TestCase(2, 7, 5, "N - ое число ряда: 0")]
        [TestCase(84, 42, 315, "N - ое число ряда: 1385850265")]
        public void DZ_3_6_Tests(int n, int n1, int n2, string expected)
        {
            string actual = Cycles.DZ_3_6(n,n1,n2);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 25, 5)]
        [TestCase(2, 7, 1)]
        [TestCase(84, 42, 42)]
        public void DZ_3_7_Tests(int a, int b,  int expected)
        {
            int actual = Cycles.DZ_3_7(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(125, 5)]
        [TestCase(729, 9)]
        public void DZ_3_8_Tests(int a, int expected)
        {
            int actual = Cycles.DZ_3_8(a);
            Assert.AreEqual(expected, actual, 0.1d);
        }

    }
}
