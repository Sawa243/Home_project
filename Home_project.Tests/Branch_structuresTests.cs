using NUnit.Framework;

namespace Home_project.Tests
{
    class Branch_structuresTests
    {
        [TestCase(5, 13, -8 )]
        [TestCase(8, 2, 10)]
        [TestCase(2, 10, -8)]
        public void DZ_2_1_Tests(int a, int b, int expected)
        {
            int actual = Branch_structures.DZ_2_1(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1,1, "Принадлежит к 1 четверти")]
        [TestCase(-1,2, "Принадлежит к 2 четверти")]
        [TestCase(-5,-6, "Принадлежит к 3 четверти")]
        public void DZ_2_2_Tests(int x, int y, string expected)
        {
            string actual = Branch_structures.DZ_2_2(x, y);
            Assert.AreEqual(expected,actual);
        }

        [TestCase(1,2,3, new int[] { 1, 2, 3 })]
        [TestCase(5, 2, 7, new int[] { 2, 5, 7 })]
        [TestCase(9, 6, 1, new int[] { 1, 6, 9 })]
        public void DZ_2_3_Tests(int a, int b, int c, int[] expected)
        {
           int [] actual = Branch_structures.DZ_2_3(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 5, "Решение: корней нет!")]
        [TestCase(1, 8, 7, "Решение: Два корня X=-1, X2=-11")]
        [TestCase(4, 8, 4, "Решение: X=-16")]
        public void DZ_2_4_Tests(int a, int b,int c, string expected)
        {
            string actual = Branch_structures.DZ_2_4(a, b,c);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(25, "Двадцать пять")]
        [TestCase(16, "Шестнадцать")]
        [TestCase(85, "Число больше 60")]
        public void DZ_2_5_Tests(int a, string expected)
        {
            string actual = Branch_structures.DZ_2_5(a);
            Assert.AreEqual(expected, actual);
        }


    }
}
