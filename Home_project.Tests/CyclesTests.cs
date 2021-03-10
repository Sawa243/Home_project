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


    }
}
