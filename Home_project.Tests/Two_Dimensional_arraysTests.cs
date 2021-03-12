using NUnit.Framework;


namespace Home_project.Tests
{
    class Two_Dimensional_arraysTests
    {
        [TestCase(1, "MaxInt: 0 MaxI: 0,0 MinInt: 0 MinI: 1,1")]
        [TestCase(2, "MaxInt: 0 MaxI: 0,0 MinInt: 0 MinI: 1,1")]
        [TestCase(3, "MaxInt: 0 MaxI: 0,0 MinInt: 0 MinI: 1,1")]
        public void DZ_5_1_4Tests (int MockNumber, string expected)
        {
            double[,] array = MockForTests.GetMock(MockNumber);
            string actual = Two_Dimensional_arrays.DZ_5_1_4(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(2, 3)]
        [TestCase(3, 3)]
        public void DZ_5_5Tests(int MockNumber, int expected)
        {
            double[,] array = MockForTests.GetMock(MockNumber);
            int actual = Two_Dimensional_arrays.DZ_5_5(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 3, 4, "1 4 22 3 7 14 5 8 55 5 9 7 ")]
        [TestCase(2, 3, 4, "2 22 82 6 5 14 7 38 45 1 11 7 ")]
        [TestCase(4, 2, 4, "7 14 6 5 7 38 6 7 ")]
        public void DZ_5_6Tests(int MockNumber,int strok, int stolbec, string expected)
        {
            double[,] array = MockForTests.GetMock(MockNumber);
            string actual = Two_Dimensional_arrays.DZ_5_6(array,strok,stolbec);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(1, 2, 0)]
        [TestCase(2, 0, 2)]
        public void DZ_5_6NegativTests(int MockNumber, int strok, int stolbec)
        {
            double[,] array = MockForTests.GetMock(MockNumber);
            try
            {
                Two_Dimensional_arrays.DZ_5_6(array, strok, stolbec);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }


    }



    public static class MockForTests
    {
        public static double[,] GetMock (int number1)
        {
            double[,] result = new double[0, 0];
            switch (number1)
            {
                case 1:
                    result = new double[,]
                    {
                        {1,3,5,5},
                        {4,7,8,9},
                        {22,14,55,7}
                    };
                    break;
                    case 2:
                    result = new double[,]
                    {
                        {2,6,7,1},
                        {22,5,38,11},
                        {82,14,45,7}
                    };
                    break;
                case 3:
                    result = new double[,]
                    {
                        {2,6,7},
                        {22,5,38},
                        {82,14,45}
                    };
                    break;
                case 4:
                    result = new double[,]
                    {
                        {7,6,7,6},
                        {14,5,38,7}
                        
                    };
                    break;
                case 5:
                    result = new double[,]
                    {
                        {7,40,7,6},
                        {14,5,38,7},
                        {7,6,50,6},
                        {14,5,38,7}

                    };
                    break;
            }
            return result;
        }
    }
}
