using NUnit.Framework;

namespace Home_project.Tests
{
    class ArraysTests
    {
        [TestCase(new int [] { 1, 3, 5, 2, 4, 8 }, "МинЧисло: 1 МинИндекс: 1 МаксЧисло: 8 МаксИндекс: 6")]
        [TestCase(new int[] { 11, 32, 55, 2, 44, 8 }, "МинЧисло: 2 МинИндекс: 4 МаксЧисло: 55 МаксИндекс: 3")]
        [TestCase(new int[] { 16, 3, 56, 2, 2, 1 }, "МинЧисло: 1 МинИндекс: 6 МаксЧисло: 56 МаксИндекс: 3")]
        public void DZ_4_1_4Tests(int[] array, string expected)
        {
            string actual = Arrayss.DZ_4_1_4(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 7, 9 }, 25)]
        [TestCase(new int[] { 11, 32, 55, 2, 44, 8 }, 66)]
        [TestCase(new int[] { 16, 3, 56, 2, 2, 1, 8 }, 4)]
        public void DZ_4_5Tests(int[] array, int expected)
        {
            int actual = Arrayss.DZ_4_5(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 7, 9 }, "9 7 5 3 1 ")]
        [TestCase(new int[] { 11, 32, 55, 2, 44, 8 }, "8 44 2 55 32 11 ")]
        [TestCase(new int[] { 16, 3, 56, 2, 2, 1, 8 }, "8 1 2 2 56 3 16 ")]
        public void DZ_4_6Tests(int[] array, string expected)
        {
            string actual = Arrayss.DZ_4_6(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 8, 14, 5, 7, 22 }, 2)]
        [TestCase(new int[] { 12, 36, 5, 20, 44, 89 }, 2)]
        [TestCase(new int[] { 11, 31, 56, 28, 2, 11, 8 }, 3)]
        public void DZ_4_7Tests(int[] array, int expected)
        {
            int actual = Arrayss.DZ_4_7(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 14, 5, 7, 22 }, "5 7 22 8 14 ")]
        [TestCase(new int[] { 12, 36, 5, 20, 44, 89 }, "20 44 89 12 36 5 ")]
        [TestCase(new int[] { 11, 31, 56, 28, 2, 11, 8 }, "28 2 11 8 11 31 56 ")]
        public void DZ_4_8Tests(int[] array, string expected)
        {
            string actual = Arrayss.DZ_4_8(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 8, 14, 5, 7, 22 }, new int[] { 5, 7, 8, 14, 22})]
        [TestCase(new int[] { 12, 36, 5, 20, 44, 89 }, new int[] {5, 12, 20, 36, 44, 89})]
        [TestCase(new int[] { 11, 31, 56, 28, 2, 11, 8 }, new int[] { 2, 8, 11, 11, 28, 31, 56})]
        public void DZ_4_9Tests(int[] array, int[] expected)
        {
            int[] actual = Arrayss.DZ_4_9(array);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] {0})]
        public void DZ_4_9TestsNegativ(int[] array)
        {
            try
            {
                Arrayss.DZ_4_9(array);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
            
        }



        [TestCase(new int[] { 8, 14, 5, 7, 22 }, "22 14 8 7 5 ")]
        [TestCase(new int[] { 12, 36, 5, 20, 44, 89 }, "89 44 36 20 12 5 ")]
        [TestCase(new int[] { 11, 31, 56, 28, 2, 11, 8 }, "56 31 28 11 11 8 2 ")]
        public void DZ_4_10Tests(int[] array, string expected)
        {
            string actual = Arrayss.DZ_4_10(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
